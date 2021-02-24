using StudyEnrollment.Model;
using StudyEnrollment.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudyEnrollment.BusinessLogic
{
    public class StudentLogic : BaseLogic<Student>
    {
        public StudentLogic(IDataRepository<Student> repo) : base(repo)
        { }

        public override void Add(Student[] pocos)
        {
            base.Add(pocos);
        }

        public override void Update(Student[] pocos)
        {
            base.Update(pocos);
        }

        public override List<Student> GetAll()
        {
            Expression<Func<Student, object>> filter1 = c => c.Enrollments;
            var filterExpressions = new List<Expression<Func<Student, object>>> { filter1 }.ToArray();

            return _repository.GetAll(filterExpressions).ToList();
        }


    }
}
