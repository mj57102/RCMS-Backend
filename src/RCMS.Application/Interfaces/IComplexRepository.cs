
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «مجتمع» مبتنی بر Stored Procedure</summary>
    public interface IComplexRepository
    {
        Task<long> CreateAsync(ComplexDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ComplexDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ComplexDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ComplexDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
