
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «طبقه»</summary>
    public interface IFloorService
    {
        Task<long> CreateAsync(FloorDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(FloorDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<FloorDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<FloorDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
