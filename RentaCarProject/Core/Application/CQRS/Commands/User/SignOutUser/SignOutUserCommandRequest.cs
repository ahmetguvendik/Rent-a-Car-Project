using System;
using MediatR;

namespace Application.CQRS.Commands.User.SignOutUser
{
	public class SignOutUserCommandRequest : IRequest<SignOutUserCommandResponse>
	{
		public SignOutUserCommandRequest()
		{
		}
	}
}

