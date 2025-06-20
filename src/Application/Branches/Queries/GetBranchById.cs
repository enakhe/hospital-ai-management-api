using System.ComponentModel.DataAnnotations;
using HospitalManagement.Application.Common.DTOs.Administrator;
using HospitalManagement.Application.Common.Interfaces.Administrator;

namespace HospitalManagement.Application.Branches.Queries;

public record GetBranchByIdQuery : IRequest<BranchDto>
{
    [Required]
    public required Guid Id { get; set; }
}

public class GetBranchByIdQueryHandler(IBranchService branchService) : IRequestHandler<GetBranchByIdQuery, BranchDto>
{
    private readonly IBranchService _branchService = branchService;

    public async Task<BranchDto> Handle(GetBranchByIdQuery request, CancellationToken cancellationToken)
    {
        return await _branchService.GetBranchByIdAsync(request.Id);
    }
}
