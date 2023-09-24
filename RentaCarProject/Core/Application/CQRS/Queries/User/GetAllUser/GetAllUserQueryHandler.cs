using System;
using Application.Services;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.User.GetAllUser
{
	public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, List<AppUser>>
	{
        private readonly IUserService _userService;
		public GetAllUserQueryHandler(IUserService userService)
		{
            _userService = userService;
		}

        public async Task<List<AppUser>> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var users = _userService.GetUser();
            return users;
        }
    }
}

