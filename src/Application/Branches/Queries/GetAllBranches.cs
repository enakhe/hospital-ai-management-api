using HospitalManagement.Application.Common.DTOs.Administrator;
using HospitalManagement.Application.Common.Interfaces.Administrator;
using HotelManagement.Application.Common.Interfaces;

namespace HospitalManagement.Application.Branches.Queries;

public record GetAllBranchesQuery : IRequest<IEnumerable<BranchDto>>
{
}

public class GetAllBranchesQueryHandler(IBranchService branchService) : IRequestHandler<GetAllBranchesQuery, IEnumerable<BranchDto>>
{
    private readonly IBranchService _branchService = branchService;

    public async Task<IEnumerable<BranchDto>> Handle(GetAllBranchesQuery request, CancellationToken cancellationToken)
    {
        var branches = await _branchService.GetAllBranchesAsync();

        return branches;
    }
}
