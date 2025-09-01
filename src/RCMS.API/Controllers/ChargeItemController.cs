
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «آیتم شارژ»</summary>
    [ApiController]
    [Route("api/ChargeItem")]
    public class ChargeItemController : ControllerBase
    {
        private readonly IChargeItemService _svc;
        public ChargeItemController(IChargeItemService svc) => _svc = svc;

        /// <summary>ایجاد آیتم شارژ</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ChargeItemDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش آیتم شارژ</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ChargeItemDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی آیتم شارژ</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت آیتم شارژ با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده آیتم شارژ</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
