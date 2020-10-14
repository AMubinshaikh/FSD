using System;

namespace Algorithms_Concepts {
    class Program {
        static void Main (string[] args) 
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            
            //Bubble sort Ascending Order
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(numbers);

            Console.WriteLine("The sorted numbers are:");
            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

           //---------------------------

           //Bubble sot Descending Order
            BubbleSortDescending bubbleSortDescending = new BubbleSortDescending();
            bubbleSortDescending.SortDescending(numbers);
            Console.WriteLine("The sorted numbers are:");
             foreach (int element in numbers)
            {
                 Console.WriteLine(element);
            }
     
        //---------------------------

        //Binary Search With Recursive Method   

           BinarySearch binarySearch = new BinarySearch();
        
           Console.WriteLine ("Enter number to search?");
           int searchElement = Convert.ToInt32 (Console.ReadLine ());
            
            Console.WriteLine ("index no. is = " + 
                binarySearch.SearchElementIndex (numbers, 0, numbers.Length-1, searchElement));


        //---------------------------

        // Recursive Methods Find Factorial of given Number

         Factorial factorial = new Factorial();
          Console.WriteLine("Enter a Number");
          int number = Convert.ToInt32(Console.ReadLine());

          int result = factorial.CalculateFactorial(number);
          Console.WriteLine("Factorial = "+ result);

        //---------------------------

        // Recursive Methods Find Element in given Array using Quick Sort

           QuickSortNumbers quickSortNumbers = new QuickSortNumbers();
       
           quickSortNumbers.QuickSort(numbers);

           Console.WriteLine("The sorted numbers are:");
            foreach (int element in numbers)
            {
                Console.WriteLine(element);
             }
    }
}
}
