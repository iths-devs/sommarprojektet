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
    public class CourseController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public CourseController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            return _unitOfWork.AddCourse(course) ?
                Conflict($"Id {course.Id} is already taken.") :
                Ok();
        }

        [HttpGet]
        public ActionResult<ICollection<Course>> GetCourses()
        {
            return Ok(_unitOfWork.GetCourses());
        }

        [HttpGet("{id:int}")]
        public ActionResult<Course> GetCourse(int id)
        {
            var result = _unitOfWork.GetCourse(id);
            return result is not null ? Ok(result) : NotFound();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateCourse(int id, Course course)
        {
            return _unitOfWork.UpdateCourse(id, course) ? Ok() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCourse(int id)
        {
            return _unitOfWork.DeleteCourse(id) ? Ok() : NotFound();
        }
        
    }
}
