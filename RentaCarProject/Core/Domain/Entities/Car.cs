using System;
namespace Domain.Entities
{
	public class Car
	{
		public string Id { get; set; }
		public string Marka { get; set; }
		public string Model { get; set; }
		public int Yil { get; set; }
		public string Yakit { get; set; }
		public string Vites { get; set; }
		public bool IsAirBag { get; set; }
		public bool IsRent { get; set; }
		public bool IsOk { get; set; }
		public AppUser User { get; set; }
		public string UserId { get; set; }	
	}
}

