using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomainModel
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Task<List<Student>> GetAllAsync();

        Student AddStudent(Student student);
    }
}