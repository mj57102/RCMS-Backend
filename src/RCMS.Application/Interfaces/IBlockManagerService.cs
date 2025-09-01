
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «مدیر بلوک»</summary>
    public interface IBlockManagerService
    {
        Task<long> CreateAsync(BlockManagerDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(BlockManagerDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<BlockManagerDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<BlockManagerDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
