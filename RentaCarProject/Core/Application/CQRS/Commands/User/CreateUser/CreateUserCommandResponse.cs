using System;
namespace Application.CQRS.Commands.User.CreateUser
{
	public class CreateUserCommandResponse 
	{
       
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

