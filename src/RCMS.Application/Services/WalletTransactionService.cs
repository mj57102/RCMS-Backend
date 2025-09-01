
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «تراکنش کیف پول»</summary>
    public class WalletTransactionService : IWalletTransactionService
    {
        private readonly IWalletTransactionRepository _repo;
        public WalletTransactionService(IWalletTransactionRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(WalletTransactionDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(WalletTransactionDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<WalletTransactionDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<WalletTransactionDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
