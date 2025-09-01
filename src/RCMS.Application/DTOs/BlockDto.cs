
using System.ComponentModel.DataAnnotations;

namespace RCMS.Application.DTOs
{
    /// <summary>DTO «بلوک» برای تبادل با API</summary>
    public class BlockDto
    {
        [Display(Name="بلوک - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="بلوک - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="بلوک - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="بلوک - توضیحات")] public string? Description { get; set; }
        [Display(Name="فعال؟")] public bool IsActive { get; set; } = true;
        [Display(Name="حذف منطقی؟")] public bool IsDeleted { get; set; } = false;
    }
}
