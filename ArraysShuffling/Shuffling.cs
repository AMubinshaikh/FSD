using System;
namespace ArraysShuffling {
     public class Shuffling {
          public int[] Shuffle (int[] givenList, int numberOfSwap) {
               int[] result = new int[givenList.Length];

               int evenIndex = 0, oddIndex = numberOfSwap;

               for (int arrayLoop = 0; arrayLoop < givenList.Length; arrayLoop++) {
                    if (arrayLoop % 2 == 0) {
                         result[arrayLoop] = givenList[evenIndex];
                         evenIndex++;
                    } else {
                         result[arrayLoop] = givenList[oddIndex];
                         oddIndex++;
                    }
               }

               return result;
          }
     }
}