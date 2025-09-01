
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «طرح اشتراک» مبتنی بر Stored Procedure</summary>
    public interface ISubscriptionPlanRepository
    {
        Task<long> CreateAsync(SubscriptionPlanDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(SubscriptionPlanDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<SubscriptionPlanDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<SubscriptionPlanDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
