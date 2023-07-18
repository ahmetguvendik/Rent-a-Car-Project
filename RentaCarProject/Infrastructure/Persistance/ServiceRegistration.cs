﻿using System;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Contexts;

namespace Persistance
{
	public static class ServiceRegistration
	{
        public static void AddPersistanceService(this IServiceCollection collection)
        {
            collection.AddDbContext<CarDbContext>(opt => opt.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=CarDb;"));
            collection.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<CarDbContext>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);
            
        }
    }
}

