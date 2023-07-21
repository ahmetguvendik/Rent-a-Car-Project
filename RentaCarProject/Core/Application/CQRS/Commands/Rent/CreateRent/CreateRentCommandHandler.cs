using System;
using Application.Repositories;
using MediatR;

namespace Application.CQRS.Commands.Rent.CreateRent
{
	public class CreateRentCommandHandler : IRequestHandler<CreateRentCommandRequest,CreateRentCommandResponse>
	{
        private readonly IRentWriteRepository _writeRepository;
		public CreateRentCommandHandler(IRentWriteRepository writeRepository)
		{
            _writeRepository = writeRepository;
		}

        public async Task<CreateRentCommandResponse> Handle(CreateRentCommandRequest request, CancellationToken cancellationToken)
        {
            var rent = new Domain.Entities.Rent();
            rent.Id = Guid.NewGuid().ToString();
            rent.TcNo = request.TcNo;
            rent.Name = request.Name;
            rent.Surname = request.Surname;
            rent.StartingTime = request.StartingTime;
            rent.FinisihingTime = request.FinisihingTime;
            rent.IsOk = false;
            rent.CarId = request.CarId;
            rent.UserId = request.UserId;
            await _writeRepository.AddAsync(rent);
            await _writeRepository.SaveAsync();
            return new CreateRentCommandResponse()
            {
                TcNo = request.TcNo,
                Name = request.Name,
                Surname = request.Surname,
                StartingTime = request.StartingTime,
                FinisihingTime = request.FinisihingTime,
                IsOk = false,
                CarId = request.CarId,
                UserId = request.UserId
               
             
            };
        }
    }
}

