using System;
using Application.Services;
using Application.ViewModels;
using MediatR;

namespace Application.CQRS.Queries.User.GetAllUserRole
{
	public class GetAllUserRoleQueryHandler : IRequestHandler<GetAllUserRoleQueryRequest, IQueryable<UserRoleViewModel>>
	{
        private readonly IUserService _userService;
		public GetAllUserRoleQueryHandler(IUserService userService)
		{
            _userService = userService;
		}

        public async Task<IQueryable<UserRoleViewModel>> Handle(GetAllUserRoleQueryRequest request, CancellationToken cancellationToken)
        {
            var userRole = _userService.GetUserRoles();
            return userRole;
        }
    }
}

