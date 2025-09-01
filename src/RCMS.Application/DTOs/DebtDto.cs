
using System.ComponentModel.DataAnnotations;

namespace RCMS.Application.DTOs
{
    /// <summary>DTO «بدهی» برای تبادل با API</summary>
    public class DebtDto
    {
        [Display(Name="بدهی - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="بدهی - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="بدهی - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="بدهی - توضیحات")] public string? Description { get; set; }
        [Display(Name="فعال؟")] public bool IsActive { get; set; } = true;
        [Display(Name="حذف منطقی؟")] public bool IsDeleted { get; set; } = false;
    }
}
