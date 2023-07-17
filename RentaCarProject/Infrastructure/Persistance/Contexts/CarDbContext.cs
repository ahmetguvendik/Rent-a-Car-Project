using System;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts
{
	public class CarDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public CarDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }    
    }
}

