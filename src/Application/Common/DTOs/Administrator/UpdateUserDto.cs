using System.ComponentModel.DataAnnotations;
using HospitalManagement.Domain.Enums;

namespace HospitalManagement.Application.Common.DTOs.Administrator;
public class UpdateUserDto
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    public string? MiddleName { get; set; }

    public GenderData Gender { get; set; }

    [Phone]
    public string? PhoneNumber { get; set; }

    public Guid BranchId { get; set; }

    public List<Guid> RoleIds { get; set; } = [];
}
