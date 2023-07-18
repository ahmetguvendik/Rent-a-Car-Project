using System;
using System.Reflection.Metadata;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class CarWriteRepository : WriteRepository<Car>, ICarWriteRepository
    {
        public BlogWriteRepository(CarDbContext context) : base(context)
        {

        }
    }
}

