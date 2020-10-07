//Description
// There are n engineers numbered from 1 to n and two arrays: 
// speed and efficiency, where speed[i] and efficiency[i] represent the speed and efficiency 
// for the i-th engineer respectively. Return the maximum performance of a team composed of 
// at most k engineers, since the answer can be a huge number, return this modulo 10^9 + 7.
// The performance of a team is the sum of their engineers' speeds multiplied by 
// the minimum efficiency among their engineers. 
//---------------------------------------------------------------------------------------------
// Example 1:

// Input: n = 6, speed = [2,10,3,1,5,8], efficiency = [5,4,3,9,7,2], k = 2

// Output: 60

// Explanation: 

// We have the maximum performance of the team by selecting engineer 2 
// (with speed=10 and efficiency=4) and engineer 5 (with speed=5 and efficiency=7).
//  That is, performance = (10 + 5) * min(4, 7) = 60.
//---------------------------------------------------------------------------------------------

// Example 2:

// Input: n = 6, speed = [2,10,3,1,5,8], efficiency = [5,4,3,9,7,2], k = 3

// Output: 68

// Explanation:

// This is the same example as the first but k = 3. We can select engineer 1, 
// engineer 2 and engineer 5 to get the maximum performance of the team. That is, 
// performance = (2 + 10 + 5) * min(5, 4, 7) = 68.
//--------------------------------------------------------------------------------------

// Example 3:

// Input: n = 6, speed = [2,10,3,1,5,8], efficiency = [5,4,3,9,7,2], k = 4

// Output: 72
//--------------------------------------------------------------------------------------

using System;
namespace EngineerEfficiencyDemo 
{
    public class EngineersEfficiency 
    {
        int[] arraySpeed = new int[100];
        int[] arrayEfficiency = new int[100];
        int arraySize;
        int arrayLoop;
        int sumOfSpeed=0;
        int minimumEfficiency ;
         int Result;

        public void AcceptEngineerDetails () 
        {
            //accept number of engineers
            Console.WriteLine ("Enter No Of Engineer");
            arraySize = Convert.ToInt32 (Console.ReadLine ());
            
            Console.WriteLine ("Enter Speed of " + arraySize + " Engineers");
            
            //accept speed of engineers
            for (arrayLoop = 0; arrayLoop < arraySize; arrayLoop++) 
            {
                Console.WriteLine ("Enter a Speed for Engineer = " + (arrayLoop + 1));
                arraySpeed[arrayLoop] = Convert.ToInt32 (Console.ReadLine ());
            }
            
             //accept efficiency of engineers
            for (arrayLoop = 0; arrayLoop < arraySize; arrayLoop++) 
            {
                Console.WriteLine ("Enter a Efficiency for Engineer = " + (arrayLoop + 1));
                arrayEfficiency[arrayLoop] = Convert.ToInt32 (Console.ReadLine ());
            }

        }

        public void CalculatePerformance ()
        {
            int[] tempIndex = new int[100];
            int[] tempEfficiency = new int[100];
            int[] tempSpeed = new int[100];
            int engineerNumber;
            int selectedEngineerNumber;
           
            Console.WriteLine ("Please enter number of Engineer ");
            engineerNumber = Convert.ToInt32 (Console.ReadLine ());

            for (arrayLoop = 0; arrayLoop < engineerNumber; arrayLoop++) 
            {
                Console.WriteLine ("Please select Engineer Number");
                selectedEngineerNumber = Convert.ToInt32 (Console.ReadLine ());
                tempIndex[arrayLoop] = (selectedEngineerNumber - 1);
            }

            for (arrayLoop = 0; arrayLoop < engineerNumber; arrayLoop++) 
            {
                tempEfficiency[arrayLoop] = arrayEfficiency[tempIndex[arrayLoop]];
                 tempSpeed[arrayLoop] = arraySpeed[tempIndex[arrayLoop]];    
            }

            for (arrayLoop = 0; arrayLoop < engineerNumber; arrayLoop++) 
            {
                Console.WriteLine (tempEfficiency[arrayLoop]);
            }
            minimumEfficiency = tempEfficiency[0];
            for (arrayLoop = 0; arrayLoop < engineerNumber; arrayLoop++) 
            {
                if (minimumEfficiency > tempEfficiency[arrayLoop]) 
                {
                     minimumEfficiency = tempEfficiency[arrayLoop];
                }     
            }

            for (arrayLoop = 0; arrayLoop < engineerNumber; arrayLoop++) 
            {
                sumOfSpeed = sumOfSpeed + tempSpeed[arrayLoop];  
            }
            
        }

        public void CalculateResult()
        {
            Result = sumOfSpeed*minimumEfficiency;
        }

        public void DisplayResult()
        {
               Console.WriteLine ("min= " + minimumEfficiency);
               Console.WriteLine ("sum of speed= " + sumOfSpeed);
               Console.WriteLine ("Result = " + Result);
        }
            
    }
}

