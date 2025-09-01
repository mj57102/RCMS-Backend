
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «پرداخت اشتراک»</summary>
    public class SubscriptionPaymentService : ISubscriptionPaymentService
    {
        private readonly ISubscriptionPaymentRepository _repo;
        public SubscriptionPaymentService(ISubscriptionPaymentRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(SubscriptionPaymentDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(SubscriptionPaymentDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<SubscriptionPaymentDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<SubscriptionPaymentDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
