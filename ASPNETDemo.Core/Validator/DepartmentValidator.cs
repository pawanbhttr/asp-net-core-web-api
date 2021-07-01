using ASPNETDemo.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core.Validator
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.DepartmentName)
                .NotEmpty().WithMessage("Department name cannot be empty.");
            RuleFor(x => x.GroupName)
                .NotEmpty().WithMessage("Group name cannot be empty.");
        }
    }
}
