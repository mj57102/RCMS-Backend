
using System.ComponentModel.DataAnnotations;

namespace RCMS.Application.DTOs
{
    /// <summary>DTO «امکانات مشترک» برای تبادل با API</summary>
    public class AmenityDto
    {
        [Display(Name="امکانات مشترک - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="امکانات مشترک - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="امکانات مشترک - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="امکانات مشترک - توضیحات")] public string? Description { get; set; }
        [Display(Name="فعال؟")] public bool IsActive { get; set; } = true;
        [Display(Name="حذف منطقی؟")] public bool IsDeleted { get; set; } = false;
    }
}
