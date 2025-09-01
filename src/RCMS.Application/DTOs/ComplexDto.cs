
using System.ComponentModel.DataAnnotations;

namespace RCMS.Application.DTOs
{
    /// <summary>DTO «مجتمع» برای تبادل با API</summary>
    public class ComplexDto
    {
        [Display(Name="مجتمع - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="مجتمع - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="مجتمع - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="مجتمع - توضیحات")] public string? Description { get; set; }
        [Display(Name="فعال؟")] public bool IsActive { get; set; } = true;
        [Display(Name="حذف منطقی؟")] public bool IsDeleted { get; set; } = false;
    }
}
