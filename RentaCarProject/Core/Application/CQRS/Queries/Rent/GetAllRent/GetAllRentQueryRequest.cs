using System;
using Application.ViewModels;
using MediatR;

namespace Application.CQRS.Queries.Rent.GetAllRent
{
	public class GetAllRentQueryRequest : IRequest<IQueryable<CarRentViewModel>>
	{
		public GetAllRentQueryRequest()
		{
		}
	}
}

