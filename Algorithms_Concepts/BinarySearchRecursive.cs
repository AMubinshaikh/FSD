/*
using System;
namespace Algorithms_Concepts
{
    public class BinarySearchRecursive
    {
         int arrayLoop;
        int arraySize;
        int[] array = new int[100];
        int min;
        int max;
        int search;
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
        int binarySearch (int[] array, int start_index, int end_index, int search)
          {
                if (max >= min)
                {
                    int mean = min + (max - min) / 2;
                    if (array[mean] == search)
                        return mean;
                    if (array[mean] > search)
                        return binarySearch (array, 0, mean - 1, search);
                    return binarySearch (array, mean + 1, max, search);
                }
                return -1;
            }

            public void DisplaySearchedElement()
            {
                Console.WriteLine ("Enter number to search?");
            search = Convert.ToInt32 (Console.ReadLine ());

            int index = binarySearch (array, 0, max, search);
            if (index == -1) {
                Console.WriteLine ("Element not found in the array ");
            } else {
                Console.WriteLine ("Element found at index : = " + index);
            }
            }
         }
    }
*/