
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «تیکت» مبتنی بر Stored Procedure</summary>
    public interface ITicketRepository
    {
        Task<long> CreateAsync(TicketDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(TicketDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<TicketDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<TicketDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
