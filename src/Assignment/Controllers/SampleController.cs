using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        public SampleController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome to ASP.NET core assignment!";
        }
    }
}
