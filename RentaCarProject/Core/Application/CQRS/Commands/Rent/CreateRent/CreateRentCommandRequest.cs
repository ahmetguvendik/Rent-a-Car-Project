using System;
using MediatR;

namespace Application.CQRS.Commands.Rent.CreateRent
{
	public class CreateRentCommandRequest : IRequest<CreateRentCommandResponse>
	{
		public string CarId { get; set; }
		public string UserId { get; set; }
		public string TcNo { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
        public string StartingTime { get; set; }
        public string FinisihingTime { get; set; }
		public bool IsOk { get; set; }	
	}
}

