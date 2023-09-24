using System;
using Application.Repositories;
using MediatR;

namespace Application.CQRS.Queries.Car.GetAllCar
{
	public class GetAllCarQueryHandler : IRequestHandler<GetAllCarQueryRequest, IQueryable<Domain.Entities.Car>>
    {
        private readonly ICarReadRepository _carReadRepository;
		public GetAllCarQueryHandler(ICarReadRepository carReadRepository)
		{
            _carReadRepository = carReadRepository;
		}

        public async Task<IQueryable<Domain.Entities.Car>> Handle(GetAllCarQueryRequest request, CancellationToken cancellationToken)
        {
            var cars = _carReadRepository.GetAll();
            return cars;
        }
    }
}

