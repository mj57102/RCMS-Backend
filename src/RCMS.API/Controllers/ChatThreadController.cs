
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «رشته چت»</summary>
    [ApiController]
    [Route("api/ChatThread")]
    public class ChatThreadController : ControllerBase
    {
        private readonly IChatThreadService _svc;
        public ChatThreadController(IChatThreadService svc) => _svc = svc;

        /// <summary>ایجاد رشته چت</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ChatThreadDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش رشته چت</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ChatThreadDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی رشته چت</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت رشته چت با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده رشته چت</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
