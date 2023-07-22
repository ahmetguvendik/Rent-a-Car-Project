using System;
using Domain.Entities;

namespace Application.ViewModels
{
	public class Rent_Car_View_Model
	{
        public string Id { get; set; }
        public string CarId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public bool IsAirBag { get; set; }
        public bool IsOk { get; set; }
        public string Plaka { get; set; }   

    }
}

