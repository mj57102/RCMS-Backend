
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «طرح شارژ» مبتنی بر Stored Procedure</summary>
    public interface IChargePlanRepository
    {
        Task<long> CreateAsync(ChargePlanDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ChargePlanDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ChargePlanDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ChargePlanDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
