// Multilevel Inhertance

using System;

namespace fsd1_oops_concept {
    class StudentClass // base class
    {
        public int roll_no = 10;
        public string name = "zubin";
    }
    class TeacherClass : StudentClass // Teacher is derved class deriving from base Student 
    {
        public int marks = 89;
        public float perc = 89.00F;

        public void printName () {
            Console.WriteLine ("Student Details : \n Roll No=" + roll_no + " \n Student Name = " + name);

        }
    }

    class ResultClass : TeacherClass // Result is derived class which inherits from base Teacher (which is also derived from Student class)
    {
        public void printResult () {
            Console.WriteLine ("Result : \n Marks= " + marks + " \n Percentage = " + perc);
        }

    }
    class Multilevel_Inheritance {
        public static void Main (string[] args) {

            //we are going to create only derived class object and can access all base class member

            ResultClass rc = new ResultClass (); // esult class is derived class
            rc.printName ();
            rc.printResult ();
        }
    }
}