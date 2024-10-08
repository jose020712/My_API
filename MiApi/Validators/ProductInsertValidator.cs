﻿using FluentValidation;
using MiApi.DTOs;
using MiApi.Models;

namespace MiApi.Validators
{
    public class ProductInsertValidator : AbstractValidator<ProductInsertDto>
    {
        public ProductInsertValidator() 
        {
            RuleFor(b => b.Name).NotEmpty().WithMessage(b => "{PropertyName} is required");
            RuleFor(b => b.Name).Length(2, 50).WithMessage(b => "{PropertyName} should be to 2 up 50 characters");
            RuleFor(b => b.Price).NotEmpty().WithMessage(b => "{PropertyName} is required");
            RuleFor(b => b.Price).GreaterThan(0).WithMessage(b => "Error with {PropertyName} value");
            RuleFor(b => b.CategoryId).NotEmpty().WithMessage(b => "{PropertyName} is required");
            RuleFor(b => b.CategoryId).GreaterThan(0).WithMessage(b => "{PropertyName} should be between 0 -");
        }
    }
}
