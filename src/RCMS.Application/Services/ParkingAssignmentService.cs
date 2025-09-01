
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;

namespace RCMS.Application.Services
{
    /// <summary>سرویس «اختصاص پارکینگ»</summary>
    public class ParkingAssignmentService : IParkingAssignmentService
    {
        private readonly IParkingAssignmentRepository _repo;
        public ParkingAssignmentService(IParkingAssignmentRepository repo) { _repo = repo; }
        public Task<long> CreateAsync(ParkingAssignmentDto dto, long userId, long tenantId) => _repo.CreateAsync(dto, userId, tenantId);
        public Task<bool> UpdateAsync(ParkingAssignmentDto dto, long userId, long tenantId) => _repo.UpdateAsync(dto, userId, tenantId);
        public Task<bool> DeleteAsync(long id, long userId, long tenantId) => _repo.DeleteAsync(id, userId, tenantId);
        public Task<ParkingAssignmentDto?> GetByIdAsync(long id, long tenantId) => _repo.GetByIdAsync(id, tenantId);
        public Task<IEnumerable<ParkingAssignmentDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId) => _repo.GetPagedAsync(page, pageSize, search, tenantId);
    }
}
