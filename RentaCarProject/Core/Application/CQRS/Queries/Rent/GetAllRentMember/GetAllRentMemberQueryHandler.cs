using System;
using Application.Services;
using Application.ViewModels;
using MediatR;

namespace Application.CQRS.Queries.Rent.GetAllRentMember
{
	public class GetAllRentMemberQueryHandler : IRequestHandler<GetAllRentMemberQueryRequest, IEnumerable<Rent_Car_View_Model>>
	{
        private readonly IRentService _rentService;
		public GetAllRentMemberQueryHandler(IRentService rentService)
		{
            _rentService = rentService;
		}

        public async Task<IEnumerable<Rent_Car_View_Model>> Handle(GetAllRentMemberQueryRequest request, CancellationToken cancellationToken)
        {
            var cars = _rentService.GetCar();
            return cars;
        }
    }
}

