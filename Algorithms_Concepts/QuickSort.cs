//Quick Sort algorithm with recursion   
using System;
namespace Algorithms_Concepts {
    public class QuickSort {
        public int len;
        // 
        public void QuickSorts (int[] numbers) {
            sort (0, len - 1, numbers);
        }
        public void sort (int left, int right, int[] numbers) {
            int pivot, lowerEnd, upperEnd;
            lowerEnd = left;
            upperEnd = right;
            pivot = numbers[left];
            while (left < right) {
                // till last element's index is higher than pivot decrease lats elements index
                while ((numbers[right] >= pivot) && (left < right)) {
                    right--;
                }
                
                if (left != right) {
                    numbers[left] = numbers[right];
                    left++;
                }
                //if first element is lower than pivot do  increment by 1
                while ((numbers[left] <= pivot) && (left < right)) {
                    left++;
                }
                //swapping numbers
                if (left != right) {
                    numbers[right] = numbers[left];
                    right--;
                }
            }

            numbers[left] = pivot;
            pivot = left;
            left = lowerEnd;
            right = upperEnd;
             
            if (left < pivot) {
                //recursion calling itself if lower index is lower than pivot
                sort (left, pivot - 1, numbers);
            }

            if (right > pivot) {
                 //recursion calling itself if higher index is higher than pivot
                sort (pivot + 1, right, numbers);
            }
        }
    }
}