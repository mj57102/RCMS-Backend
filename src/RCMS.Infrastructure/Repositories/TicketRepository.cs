
using Dapper;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;
using RCMS.Infrastructure.Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace RCMS.Infrastructure.Repositories
{
    /// <summary>ریپازیتوری «تیکت» (Dapper + SP)</summary>
    public class TicketRepository : ITicketRepository
    {
        private readonly DapperContext _ctx;
        public TicketRepository(DapperContext ctx) => _ctx = ctx;

        public async Task<long> CreateAsync(TicketDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.ExecuteScalarAsync<long>("Ticket_Create",
                new { Title = dto.Title, TitleEn = dto.TitleEn, Description = dto.Description, CreatedBy = userId, TenantId = tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<bool> UpdateAsync(TicketDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("Ticket_Update",
                new { Id=dto.Id, Title=dto.Title, TitleEn=dto.TitleEn, Description=dto.Description, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<bool> DeleteAsync(long id, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("Ticket_SoftDelete",
                new { Id=id, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<TicketDto?> GetByIdAsync(long id, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryFirstOrDefaultAsync<TicketDto>("Ticket_GetById",
                new { Id=id, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<TicketDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryAsync<TicketDto>("Ticket_GetPaged",
                new { Page=page, PageSize=pageSize, Search=search, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
    }
}
