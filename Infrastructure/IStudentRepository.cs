using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel_CodeFirst;

namespace Infrastructure
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Task<List<Student>> GetAllAsync();

        Student AddStudent(Student student);
    }
}