using Microsoft.AspNetCore.Mvc;
using StudyEnrollment.BusinessLogic;
using StudyEnrollment.Model;
using StudyEnrollment.Pocos;


namespace StudyEnrollment.Controllers
{
    [Route("api/humbercollege/v1")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {

        private readonly EnrollmentLogic _logic;

        public EnrollmentController(AppDBContext context)
        {
            var repo = new EFGenericRepository<Enrollment>(context);
            _logic = new EnrollmentLogic(repo);
        }

        [HttpGet]
        [Route("enrollment/")]

        public ActionResult GetAllEnrollments()
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
        [Route("enrollment/")]
        public ActionResult PostEnrollment([FromBody] Enrollment[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("enrollment/")]
        public ActionResult DeleteEnrollment([FromBody] Enrollment[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }

    }
}
