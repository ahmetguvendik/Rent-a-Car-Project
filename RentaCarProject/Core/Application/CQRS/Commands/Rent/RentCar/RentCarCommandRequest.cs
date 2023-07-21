using System;
using MediatR;

namespace Application.CQRS.Commands.Rent.RentCar
{
	public class RentCarCommandRequest : IRequest<RentCarCommandResponse>
	{
        public string Id { get; set; }
    }
}

