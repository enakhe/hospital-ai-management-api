using HospitalManagement.Domain.Entities.Configuration;

namespace HospitalManagement.Application.Common.Interfaces.Administrator;
public interface IBranchRepository
{
    Task AddAsync(Branch branch);
    Task UpdateAsync(Branch branch);
    Task DeleteAsync(Branch branch);
    Task<Branch?> GetByIdAsync(Guid branchId);
    Task<List<Branch>> GetAllAsync();
}
