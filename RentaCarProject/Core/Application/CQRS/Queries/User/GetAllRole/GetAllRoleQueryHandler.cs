using System;
using Application.Services;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.User.GetAllRole
{
	public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQueryRequest, List<AppRole>>
	{
        private readonly IUserService _userService;
		public GetAllRoleQueryHandler(IUserService userService)
		{
            _userService = userService;
		}

        public async Task<List<AppRole>> Handle(GetAllRoleQueryRequest request, CancellationToken cancellationToken)
        {
            var roles = _userService.GetRole();
            return roles;
        }
    }
}

