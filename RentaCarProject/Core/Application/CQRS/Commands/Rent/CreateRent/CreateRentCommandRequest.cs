using System;
using MediatR;

namespace Application.CQRS.Commands.Rent.CreateRent
{
	public class CreateRentCommandRequest : IRequest<CreateRentCommandResponse>
	{
		public int TcNo { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Year { get; set; }	
	}
}

