using System;
using Application.Repositories;
using MediatR;

namespace Application.CQRS.Commands.Car.RemoveCar
{
	public class RemoveCarCommandHandler : IRequestHandler<RemoveCarCommandRequest,RemoveCarCommandResponse>
	{
        private readonly ICarWriteRepository _writeRepository;
		public RemoveCarCommandHandler(ICarWriteRepository writeRepository)
		{
            _writeRepository = writeRepository;
		}

        public async Task<RemoveCarCommandResponse> Handle(RemoveCarCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.RemoveAsync(request.Id);
            await _writeRepository.SaveAsync();
            return new RemoveCarCommandResponse();
        }
    }
}

