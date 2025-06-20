using HospitalManagement.Application.Common.DTOs.Administrator;

namespace HospitalManagement.Application.Common.Validators.Administrator;
public class AssignPermissionToRoleValidator : AbstractValidator<AssignPermissionsToRoleDto>
{
    public AssignPermissionToRoleValidator()
    {
        RuleFor(x => x.RoleId).NotEmpty();
        RuleFor(x => x.PermissionIds).NotEmpty()
            .WithMessage("At least one permission is requred");
    }
}
