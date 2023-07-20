using System;
using Application.Repositories;
using MediatR;

namespace Application.CQRS.Commands.Car.UpdateCar
{
	public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommandRequest,UpdateCarCommandResponse>
	{
        private readonly ICarWriteRepository _writeRepository;
        private readonly ICarReadRepository _readRepositoey;
		public UpdateCarCommandHandler(ICarWriteRepository writeRepository,ICarReadRepository readRepository)
		{
            _writeRepository = writeRepository;
            _readRepositoey = readRepository;
		}

        public async Task<UpdateCarCommandResponse> Handle(UpdateCarCommandRequest request, CancellationToken cancellationToken)
        {
            var car = await _readRepositoey.GetById(request.Id);
            car.Model = request.Model;
            car.Marka = request.Marka;
            car.Vites = request.Vites;
            car.Yakit = request.Yakit;
            car.Yil = request.Yil;
            await _writeRepository.SaveAsync();
            return new UpdateCarCommandResponse()
            {
                Id = request.Id,
                Marka = request.Marka,
                Model = request.Model,
                Vites = request.Vites,
                Yakit = request.Yakit,
                Yil = request.Yil
            };
            
        }
    }
}

