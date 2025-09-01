
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «پیام تیکت»</summary>
    public interface ITicketMessageService
    {
        Task<long> CreateAsync(TicketMessageDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(TicketMessageDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<TicketMessageDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<TicketMessageDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
