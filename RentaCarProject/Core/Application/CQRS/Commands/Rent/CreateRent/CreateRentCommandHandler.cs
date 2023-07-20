using System;
using MediatR;

namespace Application.CQRS.Commands.Rent.CreateRent
{
	public class CreateRentCommandHandler : IRequestHandler<CreateRentCommandRequest,CreateRentCommandResponse>
	{
		public CreateRentCommandHandler()
		{
		}

        public Task<CreateRentCommandResponse> Handle(CreateRentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

