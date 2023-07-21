using System;
using Domain.Entities;

namespace Application.ViewModels
{
	public class CarRentViewModel
	{
        public string Id { get; set; }  
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StartingTime { get; set; }
        public string FinisihingTime { get; set; }
        public string UserName { get; set; }
		public string CarName { get; set; }
        public bool IsOk { get; set; }  
    }
}

