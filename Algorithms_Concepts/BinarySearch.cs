//binary search with recursive function    

using System;
namespace Algorithms_Concepts
{
 public class BinarySearch
 {
          public int SearchElementIndex (int[] numbers, int min, int max, int searchElement) 
          {
            int mean = (min + max) / 2;
            if (numbers[mean] == searchElement) {
                return mean;
            } else if (min >= max) {
                return -1;
            } else if (searchElement < numbers[mean]) {
                return SearchElementIndex (numbers, min, mean, searchElement);
            } else {
                return SearchElementIndex (numbers, mean, max, searchElement);
            }
        }   
 }

}
