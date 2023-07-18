using System;
using MediatR;

namespace Application.CQRS.Commands.User.CreateUser
{
	public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
	{
     
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

