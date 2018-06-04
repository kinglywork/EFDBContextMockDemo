using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel;

namespace ApplicationService
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Task<List<Student>> GetAllStudentsAsync();

        Student AddStudent(Student student);
    }
}


