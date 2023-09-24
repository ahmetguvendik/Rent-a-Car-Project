using System;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.User.GetAllRole
{
	public class GetAllRoleQueryRequest : IRequest<List<AppRole>>
	{
		
	}
}

