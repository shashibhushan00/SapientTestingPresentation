using System;
using Microsoft.AspNetCore.Mvc;

namespace HTMLRefactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerTimeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return DateTime.Now.ToString();
        }
    }
}
