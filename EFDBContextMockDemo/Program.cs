using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDBContextMockDemo.ApplicationService;
using EFDBContextMockDemo.EFDBContextModel;
using EFDBContextMockDemo.Infrastucture;

namespace EFDBContextMockDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentService = new StudentService(new StudentRepository(new SchoolContext()));
            var students = studentService.GetAllStudents();
            
            Console.ReadLine();

        }
    }
}
