using System.ComponentModel.DataAnnotations;
using HospitalManagement.Application.Common.DTOs.Administrator;
using HospitalManagement.Application.Common.Interfaces.Administrator;

namespace HospitalManagement.Application.Branches.Commands;

public record UpdateBranchCommand(CreateBranchDto Dto) : IRequest
{
    [Required]
    public required Guid Id { get; set; }
}

public class UpdateBranchCommandHandler(IBranchService branchService) : IRequestHandler<UpdateBranchCommand>
{
    private readonly IBranchService _branchService = branchService;

    public async Task Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
    {
        await _branchService.UpdateBranchAsync(request.Id, request.Dto);
    }
}
