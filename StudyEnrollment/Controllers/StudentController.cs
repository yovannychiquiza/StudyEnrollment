using Microsoft.AspNetCore.Mvc;
using StudyEnrollment.BusinessLogic;
using StudyEnrollment.Model;
using StudyEnrollment.Pocos;


namespace StudyEnrollment.Controllers
{
    [Route("api/humbercollege/v1")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly StudentLogic _logic;

        public StudentController(AppDBContext context)
        {
            var repo = new EFGenericRepository<Student>(context);
            _logic = new StudentLogic(repo);
        }

        [HttpGet]
        [Route("student/")]

        public ActionResult GetAllStudents()
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
        [Route("student/")]
        public ActionResult PostStudent([FromBody] Student[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }
       
    }
}
