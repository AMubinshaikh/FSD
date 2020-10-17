//SINGLE INHERITANCE 
//is use to Code reusability
//is a process in which one class can acquire property of another class 
// inheritance creates parent child relationship 
// parent class is known as base class and child class is derived class
// we can derived one class property from base class 
// types of inheritance 
// single Inheritance 
// One class acquire property of single class
// Multilevel inheritance
// A class acquire property of base class which also derived from base class 
// Multiple Inheritance:
// multiple Inheritance is not support in c# because in multiple inheritance there is chance of ambiguity 
// thats why c# using Interfaces.


using System;

namespace Oops_Concepts
{
   // base class
   public class Students  
   {  
       public int rollNumber = 1;  
   }  
   // class Teacher is Derived class inherits property of Base class
   public class Teacher : Students  
   {  
       public float percentage = 89.34F;  
   }  

}
