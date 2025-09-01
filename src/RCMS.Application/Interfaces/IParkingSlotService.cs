
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «محل پارک»</summary>
    public interface IParkingSlotService
    {
        Task<long> CreateAsync(ParkingSlotDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ParkingSlotDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ParkingSlotDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ParkingSlotDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
