using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Application.Common.DTOs.Administrator;
public class AssignPermissionsToRoleDto
{
    [Required]
    public Guid RoleId { get; set; }

    [Required]
    public List<Guid> PermissionIds { get; set; } = [];
}
