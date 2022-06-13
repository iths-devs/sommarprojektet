using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplateRepositoryService _templateRepositoryService;

        public TemplateController(ITemplateRepositoryService templateRepositoryService)
        {
            _templateRepositoryService = templateRepositoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _templateRepositoryService.ReadAllAsync());
        }
    }
}