using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly DataContext _context;
        public CoursesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            return _context.Courses.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetCourse(int id)
        {
            return _context.Courses.Find();
        }
    }
}
