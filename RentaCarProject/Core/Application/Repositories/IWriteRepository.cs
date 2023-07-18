using System;
using System.Reflection.Metadata;
using Domain.Entities;

namespace Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : Car
    {
        Task AddAsync(T model);
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);
        Task SaveAsync();
    }
}

