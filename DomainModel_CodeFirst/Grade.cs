using System.Collections.Generic;
using EFDBContextMockDemo.EFDBContextModel;

namespace DomainModel_CodeFirst
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
