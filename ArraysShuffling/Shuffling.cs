
using System;
namespace ArraysShuffling
{
    public class Shuffling
    {
       
       public void Shuffle(int[] givenList , int numberOfSwap)
        {
           int[] shuffleList = new int[100];
           for(int outerLoop=0; outerLoop<numberOfSwap; outerLoop++)
           {
                Console.Write("   x"+(outerLoop+1) + " = " + givenList[outerLoop]);
           }
           Console.WriteLine();
           for(int outerLoop=numberOfSwap; outerLoop<numberOfSwap*2; outerLoop++)
           {
                Console.Write("   y"+(outerLoop-2) + " = " + givenList[outerLoop]);
           }
        }
    }
}