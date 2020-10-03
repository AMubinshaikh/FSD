//Binary Search Without using Recursion
using System;

namespace fsd3_algorithms_concept {
    class BinarySearchAlgorithm {
        public int binarySearch (int[] arr, int min, int max, int search) {
            int mean = (min + max) / 2;
            if (arr[mean] == search) {
                return mean;
            } else if (min >= max) {
                return -1;
            } else if (search < arr[mean]) {
                return binarySearch (arr, min, mean, search);
            } else {
                return binarySearch (arr, mean, max, search);
            }
        }
    }
    class Program {
        static void Main (string[] args) {

            int no;
            int search;
            int i;
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
            BinarySearchAlgorithm b = new BinarySearchAlgorithm ();
            Console.WriteLine ("index no. is = " + b.binarySearch (arr, 0, arr.Length - 1, search));
        }
    }
}