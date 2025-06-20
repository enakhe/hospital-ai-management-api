using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Application.Common.DTOs.Administrator;
public class CreateRoleDto
{
    [Required, MaxLength(50)]
    public required string Name { get; set; }

    [MaxLength(200)]
    public required string Description { get; set; }
}
