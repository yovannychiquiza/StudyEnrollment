using Microsoft.AspNetCore.Mvc;
using StudyEnrollment.BusinessLogic;
using StudyEnrollment.Model;
using StudyEnrollment.Pocos;


namespace StudyEnrollment.Controllers
{
    [Route("api/humbercollege/v1")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly CourseLogic _logic;

        public CourseController(AppDBContext context)
        {
            var repo = new EFGenericRepository<Course>(context);
            _logic = new CourseLogic(repo);
        }

        [HttpGet]
        [Route("course/")]

        public ActionResult GetAllCourses()
        {
            var System = _logic.GetAll();
            if (System == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(System);
            }
        }

        [HttpPost]
        [Route("course/")]
        public ActionResult PostCourse([FromBody] Course[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }
       
    }
}
