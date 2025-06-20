using HospitalManagement.Domain.Entities.Administrator;
using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Domain.Entities.Data;
public class ApplicationRole : IdentityRole<Guid>
{
    public string? Description { get; set; }
    public ICollection<RolePermission>? RolePermissions { get; set; }
}
