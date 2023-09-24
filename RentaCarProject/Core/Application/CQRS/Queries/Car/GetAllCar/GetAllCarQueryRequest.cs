using System;
using MediatR;

namespace Application.CQRS.Queries.Car.GetAllCar
{
	public class GetAllCarQueryRequest : IRequest<IQueryable<Domain.Entities.Car>>
    {

	}
}

