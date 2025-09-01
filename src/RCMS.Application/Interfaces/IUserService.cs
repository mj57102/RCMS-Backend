
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «کاربر»</summary>
    public interface IUserService
    {
        Task<long> CreateAsync(UserDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(UserDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<UserDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<UserDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
