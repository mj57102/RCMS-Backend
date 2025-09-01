
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «پیام تیکت»</summary>
    [ApiController]
    [Route("api/TicketMessage")]
    public class TicketMessageController : ControllerBase
    {
        private readonly ITicketMessageService _svc;
        public TicketMessageController(ITicketMessageService svc) => _svc = svc;

        /// <summary>ایجاد پیام تیکت</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]TicketMessageDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش پیام تیکت</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]TicketMessageDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی پیام تیکت</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت پیام تیکت با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده پیام تیکت</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
