using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories
{
	public interface IRepository<T> where T: Car
	{
        DbSet<T> Table { get; }
    }
}

