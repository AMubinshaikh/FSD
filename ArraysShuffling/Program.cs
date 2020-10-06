using System;

namespace ArraysShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            // program1
             ShufflingProgram1 shufflingProgram1 = new ShufflingProgram1();
             shufflingProgram1.AcceptArray();
             shufflingProgram1.DisplayShuffledElements();
            //----------------------------------------------------------
            // program2

            ShufflingProgram2 shufflingProgram2 = new ShufflingProgram2();
            shufflingProgram2.AcceptArray(); 
            shufflingProgram2.Shuffle();
        }
    }
}
