
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «اعلان» مبتنی بر Stored Procedure</summary>
    public interface INotificationRepository
    {
        Task<long> CreateAsync(NotificationDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(NotificationDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<NotificationDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<NotificationDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
