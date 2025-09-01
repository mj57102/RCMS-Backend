
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «طرح اشتراک»</summary>
    [ApiController]
    [Route("api/SubscriptionPlan")]
    public class SubscriptionPlanController : ControllerBase
    {
        private readonly ISubscriptionPlanService _svc;
        public SubscriptionPlanController(ISubscriptionPlanService svc) => _svc = svc;

        /// <summary>ایجاد طرح اشتراک</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]SubscriptionPlanDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش طرح اشتراک</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]SubscriptionPlanDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی طرح اشتراک</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت طرح اشتراک با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده طرح اشتراک</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
