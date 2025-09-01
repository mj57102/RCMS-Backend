
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «تراکنش کیف پول» مبتنی بر Stored Procedure</summary>
    public interface IWalletTransactionRepository
    {
        Task<long> CreateAsync(WalletTransactionDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(WalletTransactionDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<WalletTransactionDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<WalletTransactionDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
