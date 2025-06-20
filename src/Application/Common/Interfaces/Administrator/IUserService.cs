using HospitalManagement.Application.Common.DTOs.Administrator;

namespace HospitalManagement.Application.Common.Interfaces.Administrator;
public interface IUserService
{
    Task<Guid> CreateUserAsync(CreateUserDto dto);
    Task UpdateUserAsync(UpdateUserDto dto);
    Task DeactivateUserAsync(Guid userId);
    Task DeleteUserAsync(Guid userId);
    Task<UserDto> GetUserByIdAsync(Guid userId);
    Task<IEnumerable<UserDto>> GetAllUsersAsync();

    Task AssignRolesAsync(Guid userId, List<Guid> roleIds);
    Task<List<string>> GetUserRolesAsync(Guid userId);

    Task ResetPasswordAsync(Guid userId, string newPassword);

    Task<bool> EmailExistsAsync(string email);
    Task<bool> PhoneExistsAsync(string phoneNumber);
}
