using System;

namespace EngineerEfficiencyDemo {
    class Program {
        static void Main (string[] args) {
            // #1
            int[] speedList = { 2,10,3,1,5,8 };
            int[] efficiencyList = { 5,4,3,9,7,2 };
            int numberOfEngineers = 2;

            // # 2:
          //  int[] speedList = { 2,10,3,1,5,8 };
          //  int[] efficiencyList = { 5,4,3,9,7,2 };
           // int numberOfEngineers = 3;

            // # 3:
           // int[] arraySpeed = { 2,10,3,1,5,8 };
           // int[] arrayEfficiency = { 5,4,3,9,7,2 };
           // int numberOfEngineer = 4;

            EngineersEfficiency engineersEfficiency = new EngineersEfficiency ();
            engineersEfficiency.CalculatePerformance (speedList, efficiencyList, numberOfEngineers);
            int Result = engineersEfficiency.sumOfSpeed * engineersEfficiency.minimumEfficiency;
            Console.WriteLine ("Result = " + Result);
        }
    }
}
