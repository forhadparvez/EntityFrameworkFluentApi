using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnittyFrameworkFluentApiApp.Persistences;

namespace EnittyFrameworkFluentApiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new StudentRepository();

            foreach (var s in repo.GetAll())
            {
                Console.WriteLine($@"Name: {s.StudentName}" );
                Console.WriteLine($@"    Standard: {s.Standard.StandardName}" );

                foreach (var c in s.Courses)
                {
                    Console.WriteLine($@"    Course: {c.CourseName}");
                }

                Console.WriteLine();
            }


            Console.ReadKey(); 
        }
    }
}
