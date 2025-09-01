
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «مدیر بلوک»</summary>
    [ApiController]
    [Route("api/BlockManager")]
    public class BlockManagerController : ControllerBase
    {
        private readonly IBlockManagerService _svc;
        public BlockManagerController(IBlockManagerService svc) => _svc = svc;

        /// <summary>ایجاد مدیر بلوک</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]BlockManagerDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش مدیر بلوک</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]BlockManagerDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی مدیر بلوک</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت مدیر بلوک با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده مدیر بلوک</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
