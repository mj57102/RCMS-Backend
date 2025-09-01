
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «آیتم شارژ»</summary>
    public interface IChargeItemService
    {
        Task<long> CreateAsync(ChargeItemDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ChargeItemDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ChargeItemDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ChargeItemDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
