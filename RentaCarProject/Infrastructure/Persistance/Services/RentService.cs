using System;
using Application.Services;
using Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Services
{
	public class RentService : IRentService
	{
        private readonly CarDbContext _context;
		public RentService(CarDbContext context)
		{
            _context = context;
		}

        public IQueryable<CarRentViewModel> GetRent()
        {
            var model = from car in _context.Cars
                        join rent in _context.Rents
            on car.Id equals rent.CarId
                        join user in _context.Users
                        on rent.UserId equals user.Id
                        select new CarRentViewModel
                        {
                            UserName = user.UserName,
                            CarName = car.Plaka,
                            Name = rent.Name,
                            Surname = rent.Surname,
                            StartingTime =rent.StartingTime,
                            FinisihingTime = rent.FinisihingTime,
                            TcNo = rent.TcNo,
                            Id = rent.Id,
                            IsOk = rent.IsOk
                        };

            return model;
        }
    }
}

