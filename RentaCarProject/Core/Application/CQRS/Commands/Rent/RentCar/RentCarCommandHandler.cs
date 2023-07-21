using System;
using Application.Repositories;
using MediatR;

namespace Application.CQRS.Commands.Rent.RentCar
{
	public class RentCarCommandHandler : IRequestHandler<RentCarCommandRequest,RentCarCommandResponse>
	{
        private readonly IRentWriteRepository _writeRepository;
        private readonly IRentReadRepository _readRepository;
		public RentCarCommandHandler(IRentWriteRepository writeRepository,IRentReadRepository readRepository)
		{
            _readRepository = readRepository;
            _writeRepository = writeRepository;
		}

        public async Task<RentCarCommandResponse> Handle(RentCarCommandRequest request, CancellationToken cancellationToken)
        {
            var rent = await _readRepository.GetById(request.Id);
            rent.IsOk = true;
            await _writeRepository.SaveAsync();
            return new RentCarCommandResponse();
        }
    }
}

