
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «طرح اشتراک»</summary>
    public class SubscriptionPlanService : ISubscriptionPlanService
    {
        private readonly ISubscriptionPlanRepository _repo;
        public SubscriptionPlanService(ISubscriptionPlanRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(SubscriptionPlanDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(SubscriptionPlanDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<SubscriptionPlanDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<SubscriptionPlanDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
