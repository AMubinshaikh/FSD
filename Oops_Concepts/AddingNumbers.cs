
// polymorphism is a process in which we can use single object for many purpose in this program 
// Add() is a  function which is overloading means using Add function two tmes 
//but there is no ambiguity because we are
// using different number of parameter or we can use different type of parameters of same function name

namespace Oops_Concepts
{
    public class AddingNumbers
    {   
        // with two integer parameter
        
         public static int AddNumbers(int number1, int number2) 
         {
               return number1 +number2; 
         }
         // same name function overloading but three parameter
         public int AddNumbers(int number1, int number2 , int number3) 
         {
            return number1+number2+number3;
         }
    }
}