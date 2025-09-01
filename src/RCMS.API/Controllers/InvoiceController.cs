
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «صورتحساب»</summary>
    [ApiController]
    [Route("api/Invoice")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _svc;
        public InvoiceController(IInvoiceService svc) => _svc = svc;

        /// <summary>ایجاد صورتحساب</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]InvoiceDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش صورتحساب</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]InvoiceDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی صورتحساب</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت صورتحساب با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده صورتحساب</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
