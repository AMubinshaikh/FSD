using System;
namespace Algorithms_Concepts
{
    public class QuickSort
    {
         int arrayLoop;
        int arraySize;
        int[] array = new int[100];
       
        public int len;
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
        public void QuickSortMethod () {
            sort (0, len - 1);
        }
        public void sort (int left, int right) {
            int pivot, leftend, rightend;
            leftend = left;
            rightend = right;
            pivot = array[left];
            while (left < right) {
                while ((array[right] >= pivot) && (left < right)) {
                    right--;
                }

                if (left != right) {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] <= pivot) && (left < right)) {
                    left++;
                }

                if (left != right) {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot) {
                sort (left, pivot - 1);
            }

            if (right > pivot) {
                sort (pivot + 1, right);
            }
        }
       
        public void DisplaySortedArray()
        {
            for (int j = 0; j < arraySize; j++) 
            {
                Console.WriteLine (array[j]);
            }
        }
    }
}