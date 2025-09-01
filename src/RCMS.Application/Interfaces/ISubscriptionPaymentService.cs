
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «پرداخت اشتراک»</summary>
    public interface ISubscriptionPaymentService
    {
        Task<long> CreateAsync(SubscriptionPaymentDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(SubscriptionPaymentDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<SubscriptionPaymentDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<SubscriptionPaymentDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
