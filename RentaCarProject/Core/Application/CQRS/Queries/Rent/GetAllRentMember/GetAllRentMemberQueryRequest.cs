using System;
using Application.ViewModels;
using MediatR;

namespace Application.CQRS.Queries.Rent.GetAllRentMember
{
	public class GetAllRentMemberQueryRequest : IRequest<IEnumerable<Rent_Car_View_Model>>
	{
		
	}
}

