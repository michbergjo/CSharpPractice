using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoOOP
{
    class StudentDetails
    {
        Student student1 = new Student("Michelle", "Joseph", 3.7f);
        Student student2 = new Student(54356, "Pavol", "Smith", 2.76f);

        public void displayOutput()
        {
            student1.StudentId = 101;
            Console.WriteLine("{0} {1}'s GPA is {2:F2}", student1.FirstName, student1.LastName, student1.GPA);
            Console.WriteLine("{0} {1}'s ID is {2}", student1.FirstName, student1.LastName, student1.StudentId);
            Console.WriteLine("Student ID is {0}. {1} {2}'s GPA is {3:F2}", student2.StudentId, student2.FirstName, student2.LastName, student2.GPA);
        }
    }
}
