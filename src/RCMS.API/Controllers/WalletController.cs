
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «کیف پول»</summary>
    [ApiController]
    [Route("api/Wallet")]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _svc;
        public WalletController(IWalletService svc) => _svc = svc;

        /// <summary>ایجاد کیف پول</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]WalletDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش کیف پول</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]WalletDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی کیف پول</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت کیف پول با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده کیف پول</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
