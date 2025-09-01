
using Microsoft.AspNetCore.Mvc;
using RCMS.Application.Interfaces;
using RCMS.Application.DTOs;

namespace RCMS.API.Controllers
{
    /// <summary>API «وسیله نقلیه»</summary>
    [ApiController]
    [Route("api/Vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _svc;
        public VehicleController(IVehicleService svc) => _svc = svc;

        /// <summary>ایجاد وسیله نقلیه</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]VehicleDto dto) => Ok(new { id = await _svc.CreateAsync(dto, 1, 1) });

        /// <summary>ویرایش وسیله نقلیه</summary>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]VehicleDto dto) => (await _svc.UpdateAsync(dto, 1, 1)) ? Ok() : NotFound();

        /// <summary>حذف منطقی وسیله نقلیه</summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id) => (await _svc.DeleteAsync(id, 1, 1)) ? Ok() : NotFound();

        /// <summary>دریافت وسیله نقلیه با شناسه</summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id) { var x = await _svc.GetByIdAsync(id, 1); return x==null? NotFound(): Ok(x); }

        /// <summary>فهرست صفحه‌بندی‌شده وسیله نقلیه</summary>
        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery]int page=1,[FromQuery]int pageSize=20,[FromQuery]string? search=null) => Ok(await _svc.GetPagedAsync(page,pageSize,search,1));
    }
}
