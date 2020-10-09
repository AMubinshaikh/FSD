using System;

namespace ArraysShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //program1
             ArrayShuffle arrayShuffle = new ArrayShuffle();
             arrayShuffle.AcceptArray();
             arrayShuffle.DisplayShuffledElements();
            // //----------------------------------------------------------
            // // program2

            ArrayShuffleBasic arrayShuffleBasic = new ArrayShuffleBasic();
            arrayShuffleBasic.AcceptArray(); 
            arrayShuffleBasic.Shuffle();

        }
    }
}
