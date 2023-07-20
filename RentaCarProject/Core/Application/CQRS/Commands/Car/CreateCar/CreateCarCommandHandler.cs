using System;
using Application.Repositories;
using MediatR;

namespace Application.CQRS.Commands.Car.CreateCar
{
	public class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest,CreateCarCommandResponse>
	{
        private readonly ICarWriteRepository _writeRepository;
		public CreateCarCommandHandler(ICarWriteRepository writeRepository)
		{
            _writeRepository = writeRepository;
		}

        public async Task<CreateCarCommandResponse> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
        {
            var car = new Domain.Entities.Car();
            car.Id = Guid.NewGuid().ToString();
            car.Marka = request.Marka;
            car.Model = request.Model;
            car.IsAirBag = request.AirbagVarmi;
            car.Vites = request.Vites;
            car.Yakit = request.Yakit;
            car.Yil = request.Yil;
            await _writeRepository.AddAsync(car);
            await _writeRepository.SaveAsync();

            return new CreateCarCommandResponse()
            {
                AirbagVarmi = request.AirbagVarmi,
                Marka = request.Marka,
                Model = request.Model,
                Vites = request.Vites,
                Yakit = request.Yakit,
                Yil = request.Yil
            };
        }
    }
}

