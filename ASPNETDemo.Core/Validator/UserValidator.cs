using ASPNETDemo.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Validator
{
	public class UserValidator : AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(x => x.FirstName)
				.NotEmpty().WithMessage("Name cannot be empty.")
				.Length(8, 12).WithMessage("Name should be more then 8 characters and less than 12 character.");
		}
	}
}
