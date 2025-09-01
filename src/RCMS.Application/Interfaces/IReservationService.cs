
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط سرویس «رزرو»</summary>
    public interface IReservationService
    {
        Task<long> CreateAsync(ReservationDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ReservationDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ReservationDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ReservationDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
