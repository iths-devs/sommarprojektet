using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        public TemplateController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
    }
}