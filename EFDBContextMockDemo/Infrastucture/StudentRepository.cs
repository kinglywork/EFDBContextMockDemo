using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EFDBContextMockDemo.EFDBContextModel;

namespace EFDBContextMockDemo.Infrastucture
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ISchoolContext _context;

        public StudentRepository(ISchoolContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.OrderBy(s => s.Name).ToList();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.OrderBy(s => s.Name).ToListAsync();
        }

        public Student AddStudent(Student student)
        {
            var addedStudent = _context.Students.Add(new Student()
            {
                Grade = student.Grade,
                Name = student.Name
            });
            _context.SaveChanges();

            return addedStudent;
        }
    }
}