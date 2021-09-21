using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1;

namespace Test4
{
    class Program
    {         
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student {StudentName = "Slava", StudentAge = 20, StudentId = 2},
                new Student {StudentName = "Vanya", StudentAge = 21, StudentId = 1},
                new Student {StudentName = "Valera", StudentAge = 19, StudentId = 3},
                new Student {StudentName = "Nikita", StudentAge = 18, StudentId = 5},
                new Student {StudentName = "Sasha", StudentAge = 22, StudentId = 4}
            };

            var universities = new List<University>
            {
                new University {UniversityName = "BSEU", UniversityId = 5},
                new University {UniversityName = "BSUIR", UniversityId = 2},
                new University {UniversityName = "BSTU", UniversityId = 3},
                new University {UniversityName = "BSATU", UniversityId = 1}
            };

            var result = students.Join(universities, s => s.StudentId, u => u.UniversityId, (s, u) => 
                        (s.StudentName + " учится в " + u.UniversityName).Where(a=> s.StudentAge > 18).ToArray()).Skip(1).Take(2);
            
            // Результат вывода:
            // Vanya учится в BSATU
            // Valera учится в BSTU

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
                        
            Console.ReadKey();
        }
    }
}
