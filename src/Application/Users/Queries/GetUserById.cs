using System.ComponentModel.DataAnnotations;
using HospitalManagement.Application.Common.DTOs.Administrator;
using HospitalManagement.Application.Common.Interfaces.Administrator;

namespace HospitalManagement.Application.Users.Queries;

public record GetUserByIdQuery : IRequest<UserDto>
{
    [Required]
    public required Guid Id { get; set; }
}

public class GetUserByIdQueryHandler(IUserService userService) : IRequestHandler<GetUserByIdQuery, UserDto>
{
    private readonly IUserService _userService = userService;

    public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetUserByIdAsync(request.Id);
    }
}
