using System;
using Application.ViewModels;

namespace Application.Services
{
	public interface IRentService
	{
		IQueryable<CarRentViewModel> GetRent();
        IEnumerable<Rent_Car_View_Model> GetCar();	
    }
}

