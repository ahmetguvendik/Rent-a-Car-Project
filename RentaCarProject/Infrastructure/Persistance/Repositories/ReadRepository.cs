using System;
using Application.Repositories;
using System.Reflection.Metadata;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private CarDbContext _context;

        public ReadRepository(CarDbContext context)
		{
            _context = context;
		}

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            return Table;
        }

        public async Task<T> GetById(string id)
        {
            return await Table.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

