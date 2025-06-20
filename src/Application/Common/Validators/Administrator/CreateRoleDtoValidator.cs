﻿using HospitalManagement.Application.Common.DTOs.Administrator;

namespace HospitalManagement.Application.Common.Validators.Administrator;
public class CreateRoleDtoValidator : AbstractValidator<CreateRoleDto>
{
    public CreateRoleDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Role name is required.")
            .MaximumLength(50);

        RuleFor(x => x.Description)
            .MaximumLength(200)
            .When(x => !string.IsNullOrWhiteSpace(x.Description));
    }
}
