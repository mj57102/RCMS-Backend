
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «طرح اشتراک»</summary>
    public interface ISubscriptionPlanService
    {
        Task<long> CreateAsync(SubscriptionPlanDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(SubscriptionPlanDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<SubscriptionPlanDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<SubscriptionPlanDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
