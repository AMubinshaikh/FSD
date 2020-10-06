//Multilevel Inheritance
using System;
namespace Oops_Concepts
{
    public class StudentResult
    {
        public int roll_no = 10;
        public string name = "zubin";
    }
    class TeacherClass : StudentResult // Teacher is derved class deriving from base Student 
    {
        public int marks = 89;
        public float percentage = 89.00F;

        public void printName()
        {
            Console.WriteLine("Student Details : \n Roll No=" + roll_no + " \n Student Name = " + name);

        }
    }

    // Result is derived class which inherits from base Teacher (which is also derived from Student class)
    class ResultClass : TeacherClass   
    {
        public void printResult()
        {
            Console.WriteLine("Result : \n Marks= " + marks + " \n Percentage = " + percentage);
        }

    }
    }
