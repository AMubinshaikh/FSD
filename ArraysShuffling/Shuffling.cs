using System;
namespace ArraysShuffling {
     public class Shuffling {

          public void Shuffle (int[] givenList, int numberOfSwap) {
               int[] shuffleList = new int[100];
               for (int number = 0; number < numberOfSwap; number++) {
                    Console.Write ("   x" + (number + 1) + " = " + givenList[number]);
               }
               Console.WriteLine ();
               for (int number = numberOfSwap; number < numberOfSwap * 2; number++) {
                    Console.Write ("   y" + (number - 2) + " = " + givenList[number]);
               }
          }
     }
}