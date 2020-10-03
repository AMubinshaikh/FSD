//BubbleSort Algorith for sorting Given array in Ascending Order

using System;
using System.Collections.Generic;

namespace fsd3_algorithms_concept {
    public class BubbleSortAscending {
        public static void Main (string[] args) {
            int no;
            int i;
            int temp;
            Console.WriteLine ("Define Array size");
            no = Convert.ToInt32 (Console.ReadLine ());
            int[] arr = new int[no];

            for (i = 0; i < no; i++) {
                Console.WriteLine ("Enter Value");
                arr[i] = Convert.ToInt32 (Console.ReadLine ());
            }
            Console.WriteLine ("the Sorted array is\n");

            for (i = 0; i < no; i++) {
                for (int j = 0; j < no - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (i = 0; i < no; i++) {
                Console.WriteLine (arr[i] + "\n");
            }
        }
    }
}