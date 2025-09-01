
using System.ComponentModel.DataAnnotations;

namespace RCMS.Application.DTOs
{
    /// <summary>DTO «رشته چت» برای تبادل با API</summary>
    public class ChatThreadDto
    {
        [Display(Name="رشته چت - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="رشته چت - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="رشته چت - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="رشته چت - توضیحات")] public string? Description { get; set; }
        [Display(Name="فعال؟")] public bool IsActive { get; set; } = true;
        [Display(Name="حذف منطقی؟")] public bool IsDeleted { get; set; } = false;
    }
}
