
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «آیتم صورتحساب»</summary>
    public interface IInvoiceItemService
    {
        Task<long> CreateAsync(InvoiceItemDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(InvoiceItemDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<InvoiceItemDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<InvoiceItemDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
