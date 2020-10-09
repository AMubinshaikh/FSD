using System;
namespace ArraysShuffling
{
 public class ArrayShuffleBasic
 {
    int[] array = new int[10];
      
        int arraySize;
        int arrayLoop;
        public void AcceptArray()
        {
         Console.WriteLine("Enter array size");
         arraySize=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter element for array");
         for(arrayLoop = 0; arrayLoop<arraySize; arrayLoop++)
         {
             Console.WriteLine("Enter a value");
             array[arrayLoop] = Convert.ToInt32(Console.ReadLine());
         }
        }
  
        public void Shuffle()
        {
            int[] arrayShuffle = new int[arraySize];
            int index = 0;
            int internalLoop;
            for (arrayLoop = 0, internalLoop = arraySize-1; 
                internalLoop < arraySize; arrayLoop++, internalLoop++)
            {
                arrayShuffle[index] = array[arrayLoop];
                index++;
                arrayShuffle[index] = array[internalLoop];
                index++;  
            }
        for(arrayLoop = 0; arrayLoop<arraySize; arrayLoop++)
         {
             Console.WriteLine(arrayShuffle[arrayLoop]);
             
         }
            
        }
    }
    
}