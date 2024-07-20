using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Stock).NotEmpty();
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.SupplierId).NotEmpty();

        }
    }
}
