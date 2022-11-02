using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Dtos.EmployeeDtos;
using crud_server.Models;
using FluentValidation;

namespace crud_server.Validators
{
    public class EmployeValidator : AbstractValidator<EmployeeRequest>
    {
       public EmployeValidator()
       {
            RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("Field is required!")
            .MinimumLength(1)
            .WithMessage("Field need to have bigger than 1 character!");

            RuleFor(p => p.DepartmentId)
            .NotEmpty()
            .WithMessage("Field is required!");
            
            RuleFor(p => p.Email)
            .NotEmpty()
            .WithMessage("Field is required!")
            .EmailAddress()
            .WithMessage("Email invalid!");

             RuleFor(p => p.Salary)
            .NotEmpty()
            .WithMessage("Field is required!");
            
             RuleFor(p => p.Phone)
            .NotEmpty()
            .WithMessage("Field is required!");
       }
    }
}