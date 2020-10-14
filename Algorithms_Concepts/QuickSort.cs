//Quick Sort algorithm with recursion   
using System;
namespace Algorithms_Concepts
{
    public class QuickSortNumbers
    {
        public int len;
        public void QuickSort (int[] numbers) {
            sort (0, len - 1, numbers);
        }
        public void sort (int left, int right, int[] numbers) {
            int pivot, lowerEnd, upperEnd;
            lowerEnd = left;
            upperEnd = right;
            pivot = numbers[left];
            while (left < right) {
                while ((numbers[right] >= pivot) && (left < right)) {
                    right--;
                }

                if (left != right) {
                    numbers[left] = numbers[right];
                    left++;
                }

                while ((numbers[left] <= pivot) && (left < right)) {
                    left++;
                }

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
                sort (left, pivot - 1, numbers);
            }

            if (right > pivot) {
                sort (pivot + 1, right, numbers);
            }
        }
    }
}