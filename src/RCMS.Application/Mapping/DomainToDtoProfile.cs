
using AutoMapper;

namespace RCMS.Application.Mapping
{
    /// <summary>پروفایل نگاشت دامنه ⇄ DTO</summary>
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<RCMS.Domain.Entities.Complex, RCMS.Application.DTOs.ComplexDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Block, RCMS.Application.DTOs.BlockDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Floor, RCMS.Application.DTOs.FloorDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Unit, RCMS.Application.DTOs.UnitDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Person, RCMS.Application.DTOs.PersonDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.User, RCMS.Application.DTOs.UserDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Role, RCMS.Application.DTOs.RoleDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Lease, RCMS.Application.DTOs.LeaseDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Payment, RCMS.Application.DTOs.PaymentDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Debt, RCMS.Application.DTOs.DebtDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Ticket, RCMS.Application.DTOs.TicketDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.TicketMessage, RCMS.Application.DTOs.TicketMessageDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.PrivateMessage, RCMS.Application.DTOs.PrivateMessageDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.ChatThread, RCMS.Application.DTOs.ChatThreadDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.ChatMessage, RCMS.Application.DTOs.ChatMessageDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Poll, RCMS.Application.DTOs.PollDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.PollOption, RCMS.Application.DTOs.PollOptionDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.PollVote, RCMS.Application.DTOs.PollVoteDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Amenity, RCMS.Application.DTOs.AmenityDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Reservation, RCMS.Application.DTOs.ReservationDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.ParkingSlot, RCMS.Application.DTOs.ParkingSlotDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.ParkingAssignment, RCMS.Application.DTOs.ParkingAssignmentDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Vehicle, RCMS.Application.DTOs.VehicleDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Notification, RCMS.Application.DTOs.NotificationDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.SubscriptionPlan, RCMS.Application.DTOs.SubscriptionPlanDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Subscription, RCMS.Application.DTOs.SubscriptionDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.SubscriptionPayment, RCMS.Application.DTOs.SubscriptionPaymentDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Board, RCMS.Application.DTOs.BoardDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.BoardMember, RCMS.Application.DTOs.BoardMemberDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.BlockManager, RCMS.Application.DTOs.BlockManagerDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Invoice, RCMS.Application.DTOs.InvoiceDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.InvoiceItem, RCMS.Application.DTOs.InvoiceItemDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.ChargePlan, RCMS.Application.DTOs.ChargePlanDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.ChargeItem, RCMS.Application.DTOs.ChargeItemDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.Wallet, RCMS.Application.DTOs.WalletDto>().ReverseMap();
            CreateMap<RCMS.Domain.Entities.WalletTransaction, RCMS.Application.DTOs.WalletTransactionDto>().ReverseMap();
        }
    }
}
