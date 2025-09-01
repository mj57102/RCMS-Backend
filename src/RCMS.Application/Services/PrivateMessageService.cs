
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «پیام خصوصی»</summary>
    public class PrivateMessageService : IPrivateMessageService
    {
        private readonly IPrivateMessageRepository _repo;
        public PrivateMessageService(IPrivateMessageRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(PrivateMessageDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(PrivateMessageDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<PrivateMessageDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<PrivateMessageDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
