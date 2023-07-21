using Application.CQRS.Commands.Car.CreateCar;
using Application.CQRS.Commands.Car.RemoveCar;
using Application.CQRS.Commands.Car.UpdateCar;
using Application.CQRS.Commands.Rent.RentCar;
using Application.Repositories;
using Application.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Presentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ICarReadRepository _readRepository; 
        private readonly IMediator _mediator;
        private readonly IUserService _userService;
        private readonly IRentService _rentService;
        public AdminController(ICarReadRepository readRepository,IMediator mediator,IUserService userService,IRentService rentService)
        {
            _readRepository = readRepository;
            _mediator = mediator;
            _userService = userService;
            _rentService = rentService;
        }

        public IActionResult GetCar()
        {
            var cars = _readRepository.GetAll();
            return View(cars);
        }

        public IActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return View(response);
         }

        public async Task<IActionResult> RemoveCar(string id)
        {
            var removedCar = new RemoveCarCommandRequest();
            removedCar.Id = id;
            await _mediator.Send(removedCar);
            return RedirectToAction("GetCar", "Admin"); 
        }


        public async Task<IActionResult> UpdateCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCar(UpdateCarCommandRequest request)
        {
            await _mediator.Send(request);
            return RedirectToAction("CreateCar", "Admin");
        }

        public IActionResult GetUser()
        {
            var users = _userService.GetUser();
            return View(users);
        }

        public IActionResult GetRole()
        {
            var roles = _userService.GetRole();
            return View(roles);
        }

        public IActionResult GetUserRole()
        {
            var userRole = _userService.GetUserRoles();
            return View(userRole);
        }

        public IActionResult GetRent()
        {
            var response = _rentService.GetRent();
            return View(response);
        }

        public async Task<IActionResult> RentCar(RentCarCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return RedirectToAction("GetCar", "Admin");
        }

    }
}

