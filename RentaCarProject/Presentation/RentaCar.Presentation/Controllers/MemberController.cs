using Application.CQRS.Commands.Rent.CreateRent;
using Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentaCar.Presentation.Controllers
{
    public class MemberController : Controller
    {
        private readonly IRentService _rentService;
        private readonly IMediator _mediator;
        public MemberController(IMediator mediator,IRentService rentService)
        {
            _mediator = mediator;
            _rentService = rentService;
        }

        public IActionResult GetCar()
        {
            var cars = _rentService.GetCar();
            return View(cars);
        }

        public IActionResult Rent()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Rent(CreateRentCommandRequest request,string id)
        {
            var Userid = HttpContext.Session.GetString("Userid");
            request.CarId = id;
            request.UserId = Userid;
            var response = await _mediator.Send(request);
            return View(response);
        }

    }
}

