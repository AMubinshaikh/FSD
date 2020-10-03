//Recursive Function Calculate Factorial of any 
using System;
namespace fsd3_algorithms_concept {
    public class FactorialRecursion {

        public static void Main (string[] args) {

            int no;
            int result;
            Console.WriteLine ("Enter a No");
            no = Convert.ToInt32 (Console.ReadLine ());
            result = Factorial (no);
            Console.WriteLine ("The Factorial of give no is = " + result);

            int Factorial (int a) {
                if (a == 1 || a == 0) {
                    return 1;
                }
                return a * Factorial (a - 1);
            }
        }

    }
}