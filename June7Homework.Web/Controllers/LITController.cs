using June7Homework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace June7Homework.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LITController : ControllerBase
    {
        [HttpGet]
        [Route("getschedule")]
        public List<MonthComponent> GetScheduel()
        {
            return LITScraper.GetSchedule();
        }
    }
}
