
using System.ComponentModel.DataAnnotations;

namespace RCMS.Application.DTOs
{
    /// <summary>DTO «نقش» برای تبادل با API</summary>
    public class RoleDto
    {
        [Display(Name="نقش - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="نقش - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="نقش - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="نقش - توضیحات")] public string? Description { get; set; }
        [Display(Name="فعال؟")] public bool IsActive { get; set; } = true;
        [Display(Name="حذف منطقی؟")] public bool IsDeleted { get; set; } = false;
    }
}
