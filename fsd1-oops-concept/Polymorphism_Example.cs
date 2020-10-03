/*
// polymorphism is a process in which we can use single object for many purpose in this program 
// Add() is a  function which is overloading means using Add function two tmes but there is no ambiguity because we are
// using different number of parameter or we can use different type of parameters of same function name
*/
using System;
namespace fsd1_oops_concept {
    public class AddingNumberPoly {
        public static int Add (int num1, int num2) // with two integer parameter
        {
            return num1 + num2;
        }
        public int Add (int num1, int num2, int num3) // same name function overloading but three parameter
        {
            return num1 + num2 + num3;
        }
    }

    public class Polymorphism_Example {
        public static void Main (string[] args) {
            AddingNumberPoly a = new AddingNumberPoly (); // "a" is a instance of a class

            // calling Add Function by using
            //class name because Add is an Static type function 

            int n1, n2, n3;
            Console.WriteLine ("Enter Two Numbers");
            n1 = Convert.ToInt32 (Console.ReadLine ());
            n2 = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("The sum of two Number is = " + AddingNumberPoly.Add (n1, n2));

            //calling using object this is not static member function

            Console.WriteLine ("Enter three Numbers");
            n1 = Convert.ToInt32 (Console.ReadLine ());
            n2 = Convert.ToInt32 (Console.ReadLine ());
            n3 = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("The sum of two Number is = " + a.Add (n1, n2, n3));
        }
    }
}