using System;
using Application.Repositories;
using System.Reflection.Metadata;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories
{
	public class ReadRepository<T> : IReadRepository<T> where T : Car
    {
		public ReadRepository()
		{
		}

        public DbSet<T> Table => throw new NotImplementedException();

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}

