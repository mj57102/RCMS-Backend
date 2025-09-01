
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «واحد» مبتنی بر Stored Procedure</summary>
    public interface IUnitRepository
    {
        Task<long> CreateAsync(UnitDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(UnitDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<UnitDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<UnitDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
