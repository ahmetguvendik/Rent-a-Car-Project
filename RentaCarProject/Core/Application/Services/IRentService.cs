using System;
using Application.ViewModels;

namespace Application.Services
{
	public interface IRentService
	{
		IQueryable<CarRentViewModel> GetRent();
		
	}
}

