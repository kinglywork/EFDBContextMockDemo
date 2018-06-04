using System.Data.Entity;
using System.Threading.Tasks;
using DomainModel;

namespace Infrastructure
{
    public interface ISchoolContext
    {
        IDbSet<Student> Students { get; set; }
        IDbSet<Grade> Grades { get; set; }

        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}