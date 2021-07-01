using ASPNETDemo.Core.Entities;
using ASPNETDemo.Core.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETDemo.Core
{
    public static class ValidatorConfig
    {
        public static void RegisterValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<User>, UserValidator>();
        }
    }
}
