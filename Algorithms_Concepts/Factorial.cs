// program to find factorial of a given number

using System;
namespace Algorithms_Concepts
{
    public class Factorial
    {
        public int CalculateFactorial(int number)
        {
           if(number==0 || number==1 )
           
              return 1;
           
           else
           
              return number * CalculateFactorial(number-1);
        }
    }
}
