
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «رشته چت» مبتنی بر Stored Procedure</summary>
    public interface IChatThreadRepository
    {
        Task<long> CreateAsync(ChatThreadDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ChatThreadDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ChatThreadDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ChatThreadDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
