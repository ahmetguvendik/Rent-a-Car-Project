using System;
namespace Application.CQRS.Commands.Car.CreateCar
{
	public class CreateCarCommandResponse
	{
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public bool AirbagVarmi { get; set; }
        public string Plaka { get; set; }
    }
}

