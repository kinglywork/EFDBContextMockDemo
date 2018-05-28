using System.Data.Entity;
using System.Threading.Tasks;

namespace EFDBContextMockDemo.EFDBContextModel
{
    public class SchoolContext : DbContext, ISchoolContext
    {
        public virtual IDbSet<Student> Students { get; set; }
        public virtual IDbSet<Grade> Grades { get; set; }
    }
}