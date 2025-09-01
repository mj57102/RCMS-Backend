
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «پیام چت» مبتنی بر Stored Procedure</summary>
    public interface IChatMessageRepository
    {
        Task<long> CreateAsync(ChatMessageDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ChatMessageDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ChatMessageDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ChatMessageDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
