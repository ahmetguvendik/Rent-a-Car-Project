using System;
using Application.Services;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Services
{
	public class UserService : IUserService
	{
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly CarDbContext _context;
		public UserService(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager,CarDbContext context)
		{
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
		}

        public List<AppRole> GetRole()
        {
            return _roleManager.Roles.ToList();
        }

        public List<AppUser> GetUser()
        {
            return _userManager.Users.ToList();
        }

        public IQueryable<UserRoleViewModel> GetUserRoles()
        {
            var model = from user in _context.Users
                        join userRole in _context.UserRoles
            on user.Id equals userRole.UserId
                        join role in _context.Roles
                        on userRole.RoleId equals role.Id
                        select new UserRoleViewModel
                        {
                            UserName = user.UserName,
                            RoleName = role.Name
                        };

            return model;
        }
    }
}

