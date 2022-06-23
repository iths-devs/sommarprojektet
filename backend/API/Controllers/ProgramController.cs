using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProgramController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public ProgramController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult AddProgram(Data.Program program)
        {
            return _unitOfWork.AddProgram(program) ?
                Conflict($"Id {program.Id} is already taken.") :
                Ok();
        }

        [HttpGet]
        public ActionResult<ICollection<Data.Program>> GetPrograms()
        {
            return Ok(_unitOfWork.GetPrograms());
        }

        [HttpGet("{id:int}")]
        public ActionResult<Data.Program> GetProgram(int id)
        {
            var result = _unitOfWork.GetProgram(id);
            return result is not null ? Ok(result) : NotFound();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateProgram(int id, Data.Program program)
        {
            return _unitOfWork.UpdateProgram(id, program) ? Ok() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProgram(int id)
        {
            return _unitOfWork.DeleteProgram(id) ? Ok() : NotFound();
        }
    }
}
