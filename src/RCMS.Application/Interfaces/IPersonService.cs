
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «شخص»</summary>
    public interface IPersonService
    {
        Task<long> CreateAsync(PersonDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(PersonDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<PersonDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<PersonDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
