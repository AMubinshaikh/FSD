//binary search recursive
using System;
namespace fsd3_algorithms_concept {
    public class BinarySearchRecursive {
        public static void Main (string[] args) {

            int no, i;
            int search;
            int min = 0;

            Console.WriteLine ("Define Array size");
            no = Convert.ToInt32 (Console.ReadLine ());
            int max = no - 1;
            int[] arr = new int[no];

            for (i = 0; i < no; i++) {
                Console.WriteLine ("Enter Value");
                arr[i] = Convert.ToInt32 (Console.ReadLine ());
            }
            Console.WriteLine ("Enter number to search?");
            search = Convert.ToInt32 (Console.ReadLine ());

            int index = binarySearch (arr, min, max, search);
            if (index == -1) {
                Console.WriteLine ("Element not found in the array ");
            } else {
                Console.WriteLine ("Element found at index : = " + index);
            }

            int binarySearch (int[] array, int start_index, int end_index, int element) {
                if (max >= min) {
                    int mean = min + (max - min) / 2;
                    if (array[mean] == element)
                        return mean;
                    if (array[mean] > element)
                        return binarySearch (arr, min, mean - 1, search);
                    return binarySearch (arr, mean + 1, max, search);
                }
                return -1;
            }
        }
    }
}