
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «اجاره» مبتنی بر Stored Procedure</summary>
    public interface ILeaseRepository
    {
        Task<long> CreateAsync(LeaseDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(LeaseDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<LeaseDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<LeaseDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
