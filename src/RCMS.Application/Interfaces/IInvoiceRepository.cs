
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «صورتحساب» مبتنی بر Stored Procedure</summary>
    public interface IInvoiceRepository
    {
        Task<long> CreateAsync(InvoiceDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(InvoiceDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<InvoiceDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<InvoiceDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
