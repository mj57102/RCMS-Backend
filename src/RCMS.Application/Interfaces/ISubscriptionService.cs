
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «اشتراک»</summary>
    public interface ISubscriptionService
    {
        Task<long> CreateAsync(SubscriptionDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(SubscriptionDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<SubscriptionDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<SubscriptionDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
