using System;
using Application.ViewModels;
using Domain.Entities;

namespace Application.Services
{
	public interface IUserService
	{
		List<AppUser> GetUser();
		List<AppRole> GetRole();
		IQueryable<UserRoleViewModel> GetUserRoles();
	}
}

