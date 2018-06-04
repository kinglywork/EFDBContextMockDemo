using System.Data.Entity;
using EFDBContextMockDemo.EFDBContextModel;

namespace DomainModel_CodeFirst
{
    public class SchoolContext : DbContext, ISchoolContext
    {
        public virtual IDbSet<Student> Students { get; set; }
        public virtual IDbSet<Grade> Grades { get; set; }
    }
}