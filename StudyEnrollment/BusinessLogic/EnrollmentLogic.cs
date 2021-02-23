using StudyEnrollment.Model;
using StudyEnrollment.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnrollment.BusinessLogic
{
    public class EnrollmentLogic : BaseLogic<Enrollment>
    {
        public EnrollmentLogic(IDataRepository<Enrollment> repo) : base(repo)
        { }

        public override void Add(Enrollment[] pocos)
        {
            base.Add(pocos);
        }

        public override void Update(Enrollment[] pocos)
        {
            base.Update(pocos);
        }
       
    }
}
