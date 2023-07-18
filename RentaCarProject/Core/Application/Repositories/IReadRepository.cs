using System;
using System.Reflection.Metadata;
using Domain.Entities;

namespace Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T : Car
    {
        IQueryable<T> GetAll();
        Task<T> GetById(string id);
    }
}

