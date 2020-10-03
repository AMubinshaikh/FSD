/*
INHERITANCE 
is use to Code reusability
is a process in which one class can acquire property of another class 
inheritance creates parent child relationship 
parent class is known as base class and child class is derived class
we can derived one class property from base class 
types of inheritance 
single Inheritance 
One class acquire property of single class
Multilevel inheritance
A class acquire property of base class which also derived from base class 
Multiple Inheritance:
multiple Inheritance is not support in c# because in multiple inheritance there is chance of ambiguity 
thats why c# using Interfaces.


single inheritance example 
*/

using System;
namespace console {

    public class Students // base class
    {
        public int roll = 1;
    }
    public class Teacher : Students // class Teacher is Derived class inherits property of Base class
    {
        public float perc = 89.34F;
    }
    class Single_Inheritance {
        public static void Main (string[] args) {
            Teacher t = new Teacher ();

            Console.WriteLine ("Roll Number: " + t.roll);
            Console.WriteLine ("Percentage: " + t.perc);

        }
    }
}