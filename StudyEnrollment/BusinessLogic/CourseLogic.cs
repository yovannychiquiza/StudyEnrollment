using StudyEnrollment.Model;
using StudyEnrollment.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnrollment.BusinessLogic
{
    public class CourseLogic : BaseLogic<Course>
    {
        public CourseLogic(IDataRepository<Course> repo) : base(repo)
        { }

        public override void Add(Course[] pocos)
        {
            base.Add(pocos);
        }

        public override void Update(Course[] pocos)
        {
            base.Update(pocos);
        }
       
    }
}
