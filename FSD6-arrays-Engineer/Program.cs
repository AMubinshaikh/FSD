using System;

namespace EngineerEfficiencyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            int[] arraySpeed = { 2,10,3,1,5,8 };
            int[] arrayEfficiency = { 5,4,3,9,7,2 };
            int numberOfEngineer = 2;

            // # 2:
                int[] arraySpeed = { 2,10,3,1,5,8 };
                int[] arrayEfficiency = { 5,4,3,9,7,2 };
                int numberOfEngineer = 3;

                 // # 3:
                int[] arraySpeed = { 2,10,3,1,5,8 };
                int[] arrayEfficiency = { 5,4,3,9,7,2 };
                int numberOfEngineer = 4;

               EngineersEfficiency engineersEfficiency= new EngineersEfficiency();
           
               engineersEfficiency.CalculatePerformance(arraySpeed, arrayEfficiency, numberOfEngineer);
               int Result = engineersEfficiency.sumOfSpeed*engineersEfficiency.minimumEfficiency;

               Console.WriteLine ("min= " + engineersEfficiency.minimumEfficiency);
               Console.WriteLine ("sum of speed= " + engineersEfficiency.sumOfSpeed);
               Console.WriteLine ("Result = " + Result);
    }
}
}
