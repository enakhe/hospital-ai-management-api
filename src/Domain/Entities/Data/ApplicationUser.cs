using HospitalManagement.Domain.Entities.Administrator;
using HospitalManagement.Domain.Entities.Configuration;
using HospitalManagement.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Domain.Entities.Data;
public class ApplicationUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? FullName { get; set; }
    public byte[]? ProfilePicture { get; set; }
    public GenderData Gender { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

    public Guid BranchId { get; set; }
    public Branch? Branch { get; set; }

    public ICollection<AuditLog>? AuditLogs { get; set; }
}
