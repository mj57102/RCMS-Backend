
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «گزینه نظرسنجی»</summary>
    public interface IPollOptionService
    {
        Task<long> CreateAsync(PollOptionDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(PollOptionDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<PollOptionDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<PollOptionDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
