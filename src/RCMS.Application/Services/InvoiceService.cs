
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «صورتحساب»</summary>
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repo;
        public InvoiceService(IInvoiceRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(InvoiceDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(InvoiceDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<InvoiceDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<InvoiceDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
