
using Dapper;
using RCMS.Application.DTOs;
using RCMS.Application.Interfaces;
using RCMS.Infrastructure.Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace RCMS.Infrastructure.Repositories
{
    /// <summary>ریپازیتوری «پرداخت» (Dapper + SP)</summary>
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DapperContext _ctx;
        public PaymentRepository(DapperContext ctx) => _ctx = ctx;

        public async Task<long> CreateAsync(PaymentDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.ExecuteScalarAsync<long>("Payment_Create",
                new { Title = dto.Title, TitleEn = dto.TitleEn, Description = dto.Description, CreatedBy = userId, TenantId = tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<bool> UpdateAsync(PaymentDto dto, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("Payment_Update",
                new { Id=dto.Id, Title=dto.Title, TitleEn=dto.TitleEn, Description=dto.Description, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<bool> DeleteAsync(long id, long userId, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            var n = await cn.ExecuteAsync("Payment_SoftDelete",
                new { Id=id, UpdatedBy=userId, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
            return n>0;
        }
        public async Task<PaymentDto?> GetByIdAsync(long id, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryFirstOrDefaultAsync<PaymentDto>("Payment_GetById",
                new { Id=id, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<PaymentDto>> GetPagedAsync(int page, int pageSize, string? search, long tenantId)
        {
            using var cn = _ctx.CreateConnection();
            return await cn.QueryAsync<PaymentDto>("Payment_GetPaged",
                new { Page=page, PageSize=pageSize, Search=search, TenantId=tenantId },
                commandType: CommandType.StoredProcedure);
        }
    }
}
