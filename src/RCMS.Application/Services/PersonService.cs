
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «شخص»</summary>
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repo;
        public PersonService(IPersonRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(PersonDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(PersonDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<PersonDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<PersonDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
