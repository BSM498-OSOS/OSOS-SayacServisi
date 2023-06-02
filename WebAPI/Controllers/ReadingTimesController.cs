using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingTimesController : ControllerBase
    {
        private readonly IReadingTimeService _readingTimeService;

        public ReadingTimesController(IReadingTimeService readingTimeService)
        {
            _readingTimeService = readingTimeService;
        }

        [HttpGet("getReadingTimeById")]
        public IActionResult getreadingTimesById(Guid id)
        {
            var result = _readingTimeService.GetById(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getAllReadingTimes")]
        public IActionResult getAllreadingTimess()
        {
            var result = _readingTimeService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }
    }
}
