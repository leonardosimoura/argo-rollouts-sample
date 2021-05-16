using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argo_rollouts_sample.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string service)
        {
            return Ok(new
            {
                service,
                ok = true,
                successPercent = 0.35
            });
        }
    }
}
