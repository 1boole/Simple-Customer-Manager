using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ValidationRules.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Code).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.City).NotEmpty();
        }
    }
}
