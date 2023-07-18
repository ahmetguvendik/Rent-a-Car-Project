using System;
using System.Reflection.Metadata;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories
{
	public class WriteRepository<T> : IWriteRepository<T> where T : Car
    {
		public WriteRepository(Contexts.CarDbContext context)
		{
		}

        public DbSet<T> Table => throw new NotImplementedException();

        public Task AddAsync(T model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

