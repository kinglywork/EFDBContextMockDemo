using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel_CodeFirst;
using EFDBContextMockDemo.EFDBContextModel;

namespace ApplicationService
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Task<List<Student>> GetAllStudentsAsync();

        Student AddStudent(Student student);
    }
}


