using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistance.Contexts;

namespace Persistance
{
	public class DesignTimeDbContext : IDesignTimeDbContextFactory<CarDbContext>
    {
	

        public CarDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CarDbContext> dbContextOptions = new();
            dbContextOptions.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=CarDb;");    
            return new(dbContextOptions.Options);
        }
    }
}

