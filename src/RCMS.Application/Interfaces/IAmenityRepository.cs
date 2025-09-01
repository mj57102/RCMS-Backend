
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «امکانات مشترک» مبتنی بر Stored Procedure</summary>
    public interface IAmenityRepository
    {
        Task<long> CreateAsync(AmenityDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(AmenityDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<AmenityDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<AmenityDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
