
using System;
using System.ComponentModel.DataAnnotations;
using RCMS.Common.Constants;

namespace RCMS.Domain.Entities
{
    /// <summary>موجودیت «وسیله نقلیه» - شامل فیلدهای پایه و چندزبانه</summary>
    public class Vehicle
    {
        [Display(Name="وسیله نقلیه - شناسه")] public long Id { get; set; }
        [Required, MaxLength(200), Display(Name="وسیله نقلیه - عنوان")] public string Title { get; set; } = string.Empty;
        [MaxLength(200), Display(Name="وسیله نقلیه - عنوان (EN)")] public string? TitleEn { get; set; }
        [MaxLength(1000), Display(Name="وسیله نقلیه - توضیحات")] public string? Description { get; set; }
        [Display(Name=DisplayNames.IsActive)] public bool IsActive { get; set; } = true;
        [Display(Name=DisplayNames.IsDeleted)] public bool IsDeleted { get; set; } = false;
        [Display(Name=DisplayNames.TenantId)] public long TenantId { get; set; }
        [Display(Name=DisplayNames.CreatedBy)] public long CreatedBy { get; set; }
        [Display(Name=DisplayNames.CreatedAt)] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Display(Name=DisplayNames.UpdatedBy)] public long? UpdatedBy { get; set; }
        [Display(Name=DisplayNames.UpdatedAt)] public DateTime? UpdatedAt { get; set; }
    }
}
