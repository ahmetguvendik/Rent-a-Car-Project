using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class RentWriteRepository : WriteRepository<Rent>, IRentWriteRepository
    {
        public RentWriteRepository(CarDbContext context) : base(context)
        {

        }
    }
}

