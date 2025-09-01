
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «بدهی»</summary>
    public interface IDebtService
    {
        Task<long> CreateAsync(DebtDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(DebtDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<DebtDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<DebtDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
