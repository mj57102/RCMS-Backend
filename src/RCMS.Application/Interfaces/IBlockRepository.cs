
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «بلوک» مبتنی بر Stored Procedure</summary>
    public interface IBlockRepository
    {
        Task<long> CreateAsync(BlockDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(BlockDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<BlockDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<BlockDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
