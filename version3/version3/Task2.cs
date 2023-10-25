using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version3
{
    public class Task2
    {
        class Student
        {
            private int _studentName;
            public string Grade { get; set; }

            public Student(int studentName, string grade)
            {
                _studentName = studentName;
                Grade = grade;
            }

            public string Greeting()
            {
                return $"Hi, I'm {_studentName} and I'm in grade {Grade}.";
            }
        }

        public void task2()
        {
           
            Student student = new Student(17, "12th");

            
            string message = student.Greeting();
            Console.WriteLine(message);
        }
    }
}
