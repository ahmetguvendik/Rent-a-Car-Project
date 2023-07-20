using System;
using MediatR;

namespace Application.CQRS.Commands.Car.RemoveCar
{
	public class RemoveCarCommandRequest : IRequest<RemoveCarCommandResponse>
	{
		public string Id { get; set; }	
	}
}

