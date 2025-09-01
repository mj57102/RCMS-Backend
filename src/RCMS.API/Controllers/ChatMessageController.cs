
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «پیام چت»</summary>
    [ApiController]
    [Route("api/ChatMessage")]
    public class ChatMessageController : ControllerBase
    {
        private readonly IChatMessageService _svc;
        public ChatMessageController(IChatMessageService svc) => _svc = svc;

        /// <summary>ایجاد پیام چت</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ChatMessageDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش پیام چت</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ChatMessageDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی پیام چت</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت پیام چت با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده پیام چت</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
