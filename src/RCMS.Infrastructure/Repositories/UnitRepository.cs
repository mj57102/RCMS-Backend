
using Dapper;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;
using RCMS.Infrastructure.Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace RCMS.Infrastructure.Repositories
{
    /// <summary>ریپازیتوری «واحد» (Dapper + SP)</summary>
    public class UnitRepository : IUnitRepository
    {
        private readonly DapperContext _ctx;
        public UnitRepository(DapperContext ctx) => _ctx = ctx;

        public async Task<long> CreateAsync(UnitDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.ExecuteScalarAsync<long>("Unit_Create",
                new { Title = dto.Title, TitleEn = dto.TitleEn, Description = dto.Description, CreatedBy = userId, TenantId = tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<bool> UpdateAsync(UnitDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("Unit_Update",
                new { Id=dto.Id, Title=dto.Title, TitleEn=dto.TitleEn, Description=dto.Description, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<bool> DeleteAsync(long id, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("Unit_SoftDelete",
                new { Id=id, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<UnitDto?> GetByIdAsync(long id, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryFirstOrDefaultAsync<UnitDto>("Unit_GetById",
                new { Id=id, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<UnitDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryAsync<UnitDto>("Unit_GetPaged",
                new { Page=page, PageSize=pageSize, Search=search, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
    }
}
