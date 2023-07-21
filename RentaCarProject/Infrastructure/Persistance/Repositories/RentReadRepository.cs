using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class RentReadRepository : ReadRepository<Rent>, IRentReadRepository
    {
        public RentReadRepository(CarDbContext context) : base(context)
        {
        }
    }
}

