//program for bubble sort 
//Bubble Sort Ascending order
using System;
namespace Algorithms_Concepts
{
    public class BubbleSortDescending
    {
        int arrayLoop;
        int arraySize;
        int[] array = new int[100];
        public void AcceptArray()
        {
             
             Console.WriteLine ("Define Array size");
             arraySize = Convert.ToInt32 (Console.ReadLine ());
             

               for (arrayLoop = 0; arrayLoop < arraySize; arrayLoop++) {
                   Console.WriteLine ("Enter Value");
                   array[arrayLoop] = Convert.ToInt32 (Console.ReadLine ());
            }
        }
        public void SortArray()
        {
            

           for (arrayLoop = 0; arrayLoop < arraySize; arrayLoop++) 
           {
              for (int inetrnalLoop = 0; inetrnalLoop < arraySize - 1; inetrnalLoop++) 
              {
                 if (array[inetrnalLoop] < array[inetrnalLoop + 1])
                 {
                       int temp = array[inetrnalLoop + 1];
                        array[inetrnalLoop + 1] = array[inetrnalLoop];
                        array[inetrnalLoop] = temp;
                 }
              }
            }
        }

        public void PrintSortArray()
        {
            Console.WriteLine ("The Sorted array in Descending Order is\n");
             for (arrayLoop = 0; arrayLoop < arraySize; arrayLoop++) {
                Console.WriteLine (array[arrayLoop] + "\n");
            }
        }
    }
}