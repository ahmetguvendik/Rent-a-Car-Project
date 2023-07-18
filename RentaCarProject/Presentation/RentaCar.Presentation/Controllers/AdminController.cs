using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.CQRS.Commands.Car.CreateCar;
using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentaCar.Presentation.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICarReadRepository _readRepository;
        private readonly IMediator _mediator;
        public AdminController(ICarReadRepository readRepository,IMediator mediator)
        {
            _readRepository = readRepository;
            _mediator = mediator;
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
        public async Task<IActionResult> CreateCar(CreateCarCommandRequest model)
        {
            var response = await _mediator.Send(model);
            return View(response);
        }
    }
}

