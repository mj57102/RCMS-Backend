
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «بدهی»</summary>
    [ApiController]
    [Route("api/Debt")]
    public class DebtController : ControllerBase
    {
        private readonly IDebtService _svc;
        public DebtController(IDebtService svc) => _svc = svc;

        /// <summary>ایجاد بدهی</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]DebtDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش بدهی</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]DebtDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی بدهی</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت بدهی با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده بدهی</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
