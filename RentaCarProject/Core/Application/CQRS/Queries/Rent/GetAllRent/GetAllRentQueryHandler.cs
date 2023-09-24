using System;
using Application.Services;
using Application.ViewModels;
using MediatR;

namespace Application.CQRS.Queries.Rent.GetAllRent
{
	public class GetAllRentQueryHandler : IRequestHandler<GetAllRentQueryRequest, IQueryable<CarRentViewModel>>
	{
        private readonly IRentService _rentService;
		public GetAllRentQueryHandler(IRentService rentService)
		{
            _rentService = rentService;
		}

        public async Task<IQueryable<CarRentViewModel>> Handle(GetAllRentQueryRequest request, CancellationToken cancellationToken)
        {
            var response = _rentService.GetRent();
            return response;
        }
    }
}

