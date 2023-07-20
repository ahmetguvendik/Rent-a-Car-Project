using System;
namespace Application.CQRS.Commands.Rent.CreateRent
{
	public class CreateRentCommandResponse
	{
        public int TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
    }
}

