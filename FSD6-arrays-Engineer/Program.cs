using System;

namespace EngineerEfficiencyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineersEfficiency engineersEfficiency= new EngineersEfficiency();
            engineersEfficiency.AcceptEngineerDetails();
            engineersEfficiency.CalculatePerformance();
            engineersEfficiency.CalculateResult();
            engineersEfficiency.DisplayResult();
        }
    }
}
