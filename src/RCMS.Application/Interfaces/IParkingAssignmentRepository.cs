
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;

namespace RCMS.Application.Interfaces
{
    /// <summary>رابط ریپازیتوری «اختصاص پارکینگ» مبتنی بر Stored Procedure</summary>
    public interface IParkingAssignmentRepository
    {
        Task<long> CreateAsync(ParkingAssignmentDto dto, long userId, long tenantId);
        Task<bool> UpdateAsync(ParkingAssignmentDto dto, long userId, long tenantId);
        Task<bool> DeleteAsync(long id, long userId, long tenantId);
        Task<ParkingAssignmentDto?> GetByIdAsync(long id, long tenantId);
        Task<IEnumerable<ParkingAssignmentDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId);
    }
}
