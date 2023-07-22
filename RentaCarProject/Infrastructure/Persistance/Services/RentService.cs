using System;
using Application.Services;
using Application.ViewModels;
using Domain.Entities;
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

        public IEnumerable<Rent_Car_View_Model> GetCar()
        {
            var leftModel = from car in _context.Cars
                        join rent in _context.Rents
            on car.Id equals rent.CarId
           into CarRentList from carRent in CarRentList.DefaultIfEmpty()
                        select new Rent_Car_View_Model
                        {
                            Marka = car.Marka,
                            Model = car.Model,
                            Plaka = car.Plaka,
                            IsAirBag = car.IsAirBag,
                            Yil = car.Yil,
                            Yakit = car.Yakit,
                            Vites = car.Vites,
                            CarId = car.Id,
                            IsOk = carRent.IsOk ? carRent.IsOk==true : false,
                           
                        };

            var rightModel = from rent in _context.Rents
                            join car in _context.Cars
                on rent.CarId equals car.Id
                    into CarRentList from carRent in CarRentList.DefaultIfEmpty()
                            select new Rent_Car_View_Model
                            {

                                Marka = carRent.Marka,
                                Model = carRent.Model,
                                Plaka = carRent.Plaka,
                                IsAirBag = carRent.IsAirBag,
                                Yil = carRent.Yil,
                                Yakit = carRent.Yakit,
                                Vites = carRent.Vites,
                                CarId = carRent.Id,
                                IsOk = rent.IsOk,
                            };

            var fullModel = leftModel.Union(rightModel);

            return leftModel;
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

