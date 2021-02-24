using StudyEnrollment.Model;
using StudyEnrollment.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public override List<Enrollment> GetAll()
        {
            Expression<Func<Enrollment, object>> filter1 = c => c.Course;
            Expression<Func<Enrollment, object>> filter2 = c => c.Student;

            var filterExpressions = new List<Expression<Func<Enrollment, object>>>
            { filter1, filter2}.ToArray();

            return _repository.GetAll(filterExpressions).ToList();
        }

    }
}
