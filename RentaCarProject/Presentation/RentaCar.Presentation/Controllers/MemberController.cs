using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentaCar.Presentation.Controllers
{
    public class MemberController : Controller
    {
        private readonly ICarReadRepository _readRepository;
        public MemberController(ICarReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public IActionResult GetCar()
        {
            var cars =  _readRepository.GetAll();
            return View(cars);
        }
    }
}

