
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «نقش»</summary>
    public interface IRoleService
    {
        Task<long> CreateAsync(RoleDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(RoleDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<RoleDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<RoleDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
