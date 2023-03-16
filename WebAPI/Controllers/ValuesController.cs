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

        [HttpGet("deneme")]
        public IActionResult  Get()
        {
            return Ok(_meterService.GetAll());
        }
    }
}
