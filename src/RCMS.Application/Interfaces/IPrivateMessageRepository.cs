
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «پیام خصوصی» مبتنی بر Stored Procedure</summary>
    public interface IPrivateMessageRepository
    {
        Task<long> CreateAsync(PrivateMessageDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(PrivateMessageDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<PrivateMessageDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<PrivateMessageDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
