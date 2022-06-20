using DataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace API.Controllers
{
    [Authorize]
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