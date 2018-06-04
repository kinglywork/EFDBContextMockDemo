using System.Data.Entity;
using System.Threading.Tasks;
using DomainModel_CodeFirst;

namespace EFDBContextMockDemo.EFDBContextModel
{
    public interface ISchoolContext
    {
        IDbSet<Student> Students { get; set; }
        IDbSet<Grade> Grades { get; set; }

        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}