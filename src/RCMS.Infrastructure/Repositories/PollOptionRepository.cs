
using Dapper;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;
using RCMS.Infrastructure.Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace RCMS.Infrastructure.Repositories
{
    /// <summary>ریپازیتوری «گزینه نظرسنجی» (Dapper + SP)</summary>
    public class PollOptionRepository : IPollOptionRepository
    {
        private readonly DapperContext _ctx;
        public PollOptionRepository(DapperContext ctx) => _ctx = ctx;

        public async Task<long> CreateAsync(PollOptionDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.ExecuteScalarAsync<long>("PollOption_Create",
                new { Title = dto.Title, TitleEn = dto.TitleEn, Description = dto.Description, CreatedBy = userId, TenantId = tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<bool> UpdateAsync(PollOptionDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("PollOption_Update",
                new { Id=dto.Id, Title=dto.Title, TitleEn=dto.TitleEn, Description=dto.Description, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<bool> DeleteAsync(long id, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("PollOption_SoftDelete",
                new { Id=id, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<PollOptionDto?> GetByIdAsync(long id, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryFirstOrDefaultAsync<PollOptionDto>("PollOption_GetById",
                new { Id=id, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<PollOptionDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryAsync<PollOptionDto>("PollOption_GetPaged",
                new { Page=page, PageSize=pageSize, Search=search, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
    }
}
