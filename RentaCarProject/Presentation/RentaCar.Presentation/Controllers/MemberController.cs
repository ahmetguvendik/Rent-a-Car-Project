using Application.CQRS.Commands.Rent.CreateRent;
using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentaCar.Presentation.Controllers
{
    public class MemberController : Controller
    {
        private readonly ICarReadRepository _readRepository;
        private readonly IMediator _mediator;
        public MemberController(ICarReadRepository readRepository,IMediator mediator)
        {
            _readRepository = readRepository;
            _mediator = mediator;
        }

        public IActionResult GetCar()
        {
            var cars =  _readRepository.GetAll();
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

