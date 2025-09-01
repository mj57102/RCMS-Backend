
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «کیف پول»</summary>
    public interface IWalletService
    {
        Task<long> CreateAsync(WalletDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(WalletDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<WalletDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<WalletDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
