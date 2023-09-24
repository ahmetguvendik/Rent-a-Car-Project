using Application.CQRS.Commands.Car.CreateCar;
using Application.CQRS.Commands.Car.RemoveCar;
using Application.CQRS.Commands.Car.UpdateCar;
using Application.CQRS.Commands.Rent.RentCar;
using Application.CQRS.Queries.Car.GetAllCar;
using Application.CQRS.Queries.Rent.GetAllRent;
using Application.CQRS.Queries.User.GetAllRole;
using Application.CQRS.Queries.User.GetAllUser;
using Application.CQRS.Queries.User.GetAllUserRole;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Presentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IMediator _mediator;
        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GetCar(GetAllCarQueryRequest model)
        {
            var response = await _mediator.Send(model);
            return View(response);
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

        public async Task<IActionResult> GetUser(GetAllUserQueryRequest model)
        {
            var users = await _mediator.Send(model);
            return View(users);
        }

        public async Task<IActionResult> GetRole(GetAllRoleQueryRequest model)
        {
            var roles = await _mediator.Send(model);
            return View(roles);
        }

        public async Task<IActionResult> GetUserRole(GetAllUserRoleQueryRequest model)
        {
            var Userroles = await _mediator.Send(model);
            return View(Userroles);
        }

        public async Task<IActionResult> GetRent(GetAllRentQueryRequest model)
        {
            var response = await _mediator.Send(model);
            return View(response);
        }

        public async Task<IActionResult> RentCar(RentCarCommandRequest request)
        {
            await _mediator.Send(request);
            return RedirectToAction("GetCar", "Admin");
        }

    }
}

