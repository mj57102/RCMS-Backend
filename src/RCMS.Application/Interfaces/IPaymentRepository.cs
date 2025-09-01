
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «پرداخت» مبتنی بر Stored Procedure</summary>
    public interface IPaymentRepository
    {
        Task<long> CreateAsync(PaymentDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(PaymentDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<PaymentDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<PaymentDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
