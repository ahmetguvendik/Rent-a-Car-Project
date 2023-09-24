using System;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.User.GetAllUser
{
	public class GetAllUserQueryRequest : IRequest<List<AppUser>>
	{
		
	}
}

