
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «کیف پول»</summary>
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _repo;
        public WalletService(IWalletRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(WalletDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(WalletDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<WalletDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<WalletDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
