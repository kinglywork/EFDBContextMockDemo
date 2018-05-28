using System.Collections.Generic;
using System.Threading.Tasks;
using EFDBContextMockDemo.EFDBContextModel;

namespace EFDBContextMockDemo.Infrastucture
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Task<List<Student>> GetAllAsync();

        Student AddStudent(Student student);
    }
}