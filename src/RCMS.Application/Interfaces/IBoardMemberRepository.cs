
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «عضو هیئت‌مدیره» مبتنی بر Stored Procedure</summary>
    public interface IBoardMemberRepository
    {
        Task<long> CreateAsync(BoardMemberDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(BoardMemberDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<BoardMemberDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<BoardMemberDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
