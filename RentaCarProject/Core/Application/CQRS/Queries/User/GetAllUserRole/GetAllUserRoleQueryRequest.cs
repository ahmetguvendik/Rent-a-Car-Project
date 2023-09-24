using System;
using Application.ViewModels;
using MediatR;

namespace Application.CQRS.Queries.User.GetAllUserRole
{
	public class GetAllUserRoleQueryRequest : IRequest<IQueryable<UserRoleViewModel>>
	{
		
	}
}

