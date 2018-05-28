using System.Collections.Generic;
using System.Threading.Tasks;
using EFDBContextMockDemo.EFDBContextModel;

namespace EFDBContextMockDemo.ApplicationService
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Task<List<Student>> GetAllStudentsAsync();

        Student AddStudent(Student student);
    }
}


