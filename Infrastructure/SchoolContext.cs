using System.Data.Entity;
using DomainModel;

namespace Infrastructure
{
    public class SchoolContext : DbContext, ISchoolContext
    {
        public virtual IDbSet<Student> Students { get; set; }
        public virtual IDbSet<Grade> Grades { get; set; }
    }
}