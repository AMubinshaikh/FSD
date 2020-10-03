
/*
Method Overriding

if we are declaring and implementing function name in base class and also same name 
function in derived class it only calls only base class function so we have to use virtual keyword in base class
function and override keyword in derived class function
we can declare same number of parameters and parameter type in method overriding
*/

using System;
namespace fsd1_oops_concept
{
    public class OverridingExample
    {
        public virtual void print()
        {
            Console.WriteLine("this is base class Method");
        }
    }
    public class child : OverridingExample
    {
        public override void print()
        {
            Console.WriteLine("this is Derived class Method");
        }
    }

  class Method_Overriding{
      public static void Main(string[] args)
    {
       OverridingExample baseobj = new OverridingExample();

       baseobj.print(); // base class print method calls

       child derivedobj = new child();

       derivedobj.print(); // dervied class print method calls
    }
  }   
}
