using System;
using MediatR;

namespace Application.CQRS.Commands.Car.UpdateCar
{
	public class UpdateCarCommandRequest : IRequest<UpdateCarCommandResponse>
	{
		public string Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
    }
}

