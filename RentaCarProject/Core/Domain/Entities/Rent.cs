using System;
namespace Domain.Entities
{
	public class Rent : BaseEntity
	{
        public string TcNo { get; set; }
        public string Name { get; set; }
		public string Surname { get; set; }
		public Car Car { get; set; }
		public string CarId { get; set; }
		public string StartingTime { get; set; }
		public string FinisihingTime { get; set; }
		public AppUser User { get; set; }
		public string UserId { get; set; }
		public bool IsOk { get; set; }	

	}
}

