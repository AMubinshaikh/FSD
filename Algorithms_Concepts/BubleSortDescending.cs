//program for bubble sort 
//Bubble Sort Descending order

using System;
namespace Algorithms_Concepts
{
    public class BubbleSortDescending
    { 
       public void SortArrayDescending(int[] numbers)
        {
           for (int arrayLoop = 0; arrayLoop < numbers.Length; arrayLoop++) 
           {
              for (int inetrnalLoop = 0; inetrnalLoop < numbers.Length - 1; inetrnalLoop++) 
              {
                 if (numbers[inetrnalLoop] < numbers[inetrnalLoop + 1])
                 {
                       int temp = numbers[inetrnalLoop + 1];
                        numbers[inetrnalLoop + 1] = numbers[inetrnalLoop];
                        numbers[inetrnalLoop] = temp;
                 }
              }
            }  
        }
    }
}
