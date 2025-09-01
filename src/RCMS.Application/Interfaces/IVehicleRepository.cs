
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «وسیله نقلیه» مبتنی بر Stored Procedure</summary>
    public interface IVehicleRepository
    {
        Task<long> CreateAsync(VehicleDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(VehicleDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<VehicleDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<VehicleDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
