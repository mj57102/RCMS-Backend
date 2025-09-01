
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «رأی»</summary>
    public interface IPollVoteService
    {
        Task<long> CreateAsync(PollVoteDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(PollVoteDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<PollVoteDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<PollVoteDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
