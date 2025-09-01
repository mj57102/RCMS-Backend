
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RCMS.Infrastructure.Persistence;
using RCMS.Infrastructure.Config;
using RCMS.Application.Mapping;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// تنظیمات پایگاه‌داده
builder.Services.Configure<DbOptions>(builder.Configuration.GetSection("Db"));
builder.Services.AddSingleton<DapperContext>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(DomainToDtoProfile));

// ثبت سرویس‌ها و ریپازیتوری‌ها
builder.Services.AddScoped<RCMS.Application.Interfaces.IComplexRepository, RCMS.Infrastructure.Repositories.ComplexRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IComplexService, RCMS.Application.Services.ComplexService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBlockRepository, RCMS.Infrastructure.Repositories.BlockRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBlockService, RCMS.Application.Services.BlockService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IFloorRepository, RCMS.Infrastructure.Repositories.FloorRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IFloorService, RCMS.Application.Services.FloorService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IUnitRepository, RCMS.Infrastructure.Repositories.UnitRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IUnitService, RCMS.Application.Services.UnitService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPersonRepository, RCMS.Infrastructure.Repositories.PersonRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPersonService, RCMS.Application.Services.PersonService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IUserRepository, RCMS.Infrastructure.Repositories.UserRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IUserService, RCMS.Application.Services.UserService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IRoleRepository, RCMS.Infrastructure.Repositories.RoleRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IRoleService, RCMS.Application.Services.RoleService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ILeaseRepository, RCMS.Infrastructure.Repositories.LeaseRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ILeaseService, RCMS.Application.Services.LeaseService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPaymentRepository, RCMS.Infrastructure.Repositories.PaymentRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPaymentService, RCMS.Application.Services.PaymentService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IDebtRepository, RCMS.Infrastructure.Repositories.DebtRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IDebtService, RCMS.Application.Services.DebtService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ITicketRepository, RCMS.Infrastructure.Repositories.TicketRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ITicketService, RCMS.Application.Services.TicketService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ITicketMessageRepository, RCMS.Infrastructure.Repositories.TicketMessageRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ITicketMessageService, RCMS.Application.Services.TicketMessageService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPrivateMessageRepository, RCMS.Infrastructure.Repositories.PrivateMessageRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPrivateMessageService, RCMS.Application.Services.PrivateMessageService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChatThreadRepository, RCMS.Infrastructure.Repositories.ChatThreadRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChatThreadService, RCMS.Application.Services.ChatThreadService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChatMessageRepository, RCMS.Infrastructure.Repositories.ChatMessageRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChatMessageService, RCMS.Application.Services.ChatMessageService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPollRepository, RCMS.Infrastructure.Repositories.PollRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPollService, RCMS.Application.Services.PollService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPollOptionRepository, RCMS.Infrastructure.Repositories.PollOptionRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPollOptionService, RCMS.Application.Services.PollOptionService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPollVoteRepository, RCMS.Infrastructure.Repositories.PollVoteRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IPollVoteService, RCMS.Application.Services.PollVoteService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IAmenityRepository, RCMS.Infrastructure.Repositories.AmenityRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IAmenityService, RCMS.Application.Services.AmenityService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IReservationRepository, RCMS.Infrastructure.Repositories.ReservationRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IReservationService, RCMS.Application.Services.ReservationService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IParkingSlotRepository, RCMS.Infrastructure.Repositories.ParkingSlotRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IParkingSlotService, RCMS.Application.Services.ParkingSlotService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IParkingAssignmentRepository, RCMS.Infrastructure.Repositories.ParkingAssignmentRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IParkingAssignmentService, RCMS.Application.Services.ParkingAssignmentService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IVehicleRepository, RCMS.Infrastructure.Repositories.VehicleRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IVehicleService, RCMS.Application.Services.VehicleService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.INotificationRepository, RCMS.Infrastructure.Repositories.NotificationRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.INotificationService, RCMS.Application.Services.NotificationService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ISubscriptionPlanRepository, RCMS.Infrastructure.Repositories.SubscriptionPlanRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ISubscriptionPlanService, RCMS.Application.Services.SubscriptionPlanService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ISubscriptionRepository, RCMS.Infrastructure.Repositories.SubscriptionRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ISubscriptionService, RCMS.Application.Services.SubscriptionService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ISubscriptionPaymentRepository, RCMS.Infrastructure.Repositories.SubscriptionPaymentRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.ISubscriptionPaymentService, RCMS.Application.Services.SubscriptionPaymentService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBoardRepository, RCMS.Infrastructure.Repositories.BoardRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBoardService, RCMS.Application.Services.BoardService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBoardMemberRepository, RCMS.Infrastructure.Repositories.BoardMemberRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBoardMemberService, RCMS.Application.Services.BoardMemberService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBlockManagerRepository, RCMS.Infrastructure.Repositories.BlockManagerRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IBlockManagerService, RCMS.Application.Services.BlockManagerService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IInvoiceRepository, RCMS.Infrastructure.Repositories.InvoiceRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IInvoiceService, RCMS.Application.Services.InvoiceService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IInvoiceItemRepository, RCMS.Infrastructure.Repositories.InvoiceItemRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IInvoiceItemService, RCMS.Application.Services.InvoiceItemService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChargePlanRepository, RCMS.Infrastructure.Repositories.ChargePlanRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChargePlanService, RCMS.Application.Services.ChargePlanService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChargeItemRepository, RCMS.Infrastructure.Repositories.ChargeItemRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IChargeItemService, RCMS.Application.Services.ChargeItemService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IWalletRepository, RCMS.Infrastructure.Repositories.WalletRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IWalletService, RCMS.Application.Services.WalletService>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IWalletTransactionRepository, RCMS.Infrastructure.Repositories.WalletTransactionRepository>();
builder.Services.AddScoped<RCMS.Application.Interfaces.IWalletTransactionService, RCMS.Application.Services.WalletTransactionService>();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RCMS API (فارسی)", Version = "v1", Description = "مستندات سرویس‌های RCMS" });
    var xml = System.IO.Path.Combine(System.AppContext.BaseDirectory, "RCMS.API.xml");
    if (System.IO.File.Exists(xml)) c.IncludeXmlComments(xml, true);
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o => { o.SwaggerEndpoint("/swagger/v1/swagger.json", "RCMS v1"); o.DocumentTitle = "RCMS API Docs"; });
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
