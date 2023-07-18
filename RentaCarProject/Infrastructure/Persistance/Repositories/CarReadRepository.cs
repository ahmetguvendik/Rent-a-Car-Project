using System;
using System.Reflection.Metadata;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class CarReadRepository : ReadRepository<Car>, ICarReadRepository
    {
        public CarReadRepository(CarDbContext context) : base(context)
        {
        }
    }
}

