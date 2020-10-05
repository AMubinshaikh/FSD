using System;
namespace Algorithms_Concepts
{
 public class BinarySearch
 {
     int arrayLoop;
        int arraySize;
        int search;
        int[] array = new int[100];
        public void AcceptArray()
        {
               Console.WriteLine ("Define Array size");
               arraySize = Convert.ToInt32 (Console.ReadLine ());
             
               for (arrayLoop = 0; arrayLoop < arraySize; arrayLoop++)
               {
                   Console.WriteLine ("Enter Value");
                   array[arrayLoop] = Convert.ToInt32 (Console.ReadLine ());
               }
        }
          public int BinarySearchMethod (int[] arr, int min, int max, int search) {
            int mean = (min + max) / 2;
            if (arr[mean] == search) {
                return mean;
            } else if (min >= max) {
                return -1;
            } else if (search < arr[mean]) {
                return BinarySearchMethod (arr, min, mean, search);
            } else {
                return BinarySearchMethod (arr, mean, max, search);
            }
        }
    

        public void SearchElement()
        {
             Console.WriteLine ("Enter number to search?");
            search = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("index no. is = " + BinarySearchMethod (array, 0, array.Length - 1, search));
        }  
 }

}