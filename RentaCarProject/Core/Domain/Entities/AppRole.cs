﻿using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
	public class AppRole : IdentityRole<string>
    {
		public AppRole()
		{
		}
	}
}

