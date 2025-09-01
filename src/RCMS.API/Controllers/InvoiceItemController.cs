
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «آیتم صورتحساب»</summary>
    [ApiController]
    [Route("api/InvoiceItem")]
    public class InvoiceItemController : ControllerBase
    {
        private readonly IInvoiceItemService _svc;
        public InvoiceItemController(IInvoiceItemService svc) => _svc = svc;

        /// <summary>ایجاد آیتم صورتحساب</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]InvoiceItemDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش آیتم صورتحساب</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]InvoiceItemDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی آیتم صورتحساب</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت آیتم صورتحساب با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده آیتم صورتحساب</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
