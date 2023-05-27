using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMeterService _meterService;

        public ValuesController(IMeterService meterService)
        {
            _meterService = meterService;
        }

        [HttpGet("getMeterById")]
        public IActionResult getMeterById(Guid id)
        {
            return Ok(_meterService.GetById(id));
        }
    }
}
