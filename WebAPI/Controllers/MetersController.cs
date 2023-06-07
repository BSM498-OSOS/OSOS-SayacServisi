using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetersController : ControllerBase
    {
        private readonly IMeterService _meterService;

        public MetersController(IMeterService meterService)
        {
            _meterService = meterService;
        }

        [HttpGet("getMeterById")]
        public IActionResult getMeterById(Guid id)
        {
            var result = _meterService.GetById(id);
            if(result.Success) 
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getMeterBySerialNo")]
        public IActionResult getMeterBySerialNo(int serialNo)
        {
            var result = _meterService.GetBySerialNo(serialNo);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getAllMeters")]
        public IActionResult getAllMeters()
        {
            var result = _meterService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getMeterWithCompleteInfoById")]
        public IActionResult getMeterWithCompleteInfoById(Guid id)
        {
            var result = _meterService.GetWithCompleteInfoById(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getMeterWithCompleteInfoBySerialNo")]
        public IActionResult getMeterWithCompleteInfoBySerialNo(int serialNo)
        {
            var result = _meterService.GetWithCompleteInfoBySerialNo(serialNo);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getAllMetersWithCompleteInfo")]
        public IActionResult getAllMetersWithCompleteInfo()
        {
            var result = _meterService.GetAllWithCompleteInfo();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpDelete("deleteMeter")]
        public IActionResult deleteMeter(Meter meter) 
        {
            var result = _meterService.Delete(meter);
            if( result.Success )
                return Ok(result);
            return BadRequest();
        }

        [HttpPatch("updateMeter")]
        public IActionResult updateMeter(Meter meter)
        {
            var result = _meterService.Update(meter);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost("addMeter")]
        public IActionResult addMeter(Meter meter)
        {
            var result = _meterService.Add(meter);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }
    }
}
