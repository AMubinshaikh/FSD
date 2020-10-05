using System;
namespace Algorithms_Concepts
{
    public class Factorial
    {
       public int number;
        public void AcceptNumber()
        {
            
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            
        }
        public void DisplayFactorial()
        {
            int result;
            result = CalculateFactorial(number);
            Console.WriteLine("Factorial = "+ result);
        }
        public int CalculateFactorial( int number)
        {
           if(number==0 || number==1 )
           {
            return 1;
           }
           else
           {
               return number * CalculateFactorial(number-1);
           }
        }
        
    }
}