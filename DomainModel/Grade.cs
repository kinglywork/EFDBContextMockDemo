using System.Collections.Generic;

namespace DomainModel
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
