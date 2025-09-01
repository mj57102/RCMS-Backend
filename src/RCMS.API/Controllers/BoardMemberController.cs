
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «عضو هیئت‌مدیره»</summary>
    [ApiController]
    [Route("api/BoardMember")]
    public class BoardMemberController : ControllerBase
    {
        private readonly IBoardMemberService _svc;
        public BoardMemberController(IBoardMemberService svc) => _svc = svc;

        /// <summary>ایجاد عضو هیئت‌مدیره</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]BoardMemberDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش عضو هیئت‌مدیره</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]BoardMemberDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی عضو هیئت‌مدیره</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت عضو هیئت‌مدیره با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده عضو هیئت‌مدیره</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
