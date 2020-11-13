using System;

class Program {
     static void Main(string[] args) {
        Console.WriteLine ("Hello World!");
        int number = Add (4, 5);
        System.Console.WriteLine (number);

        System.Console.WriteLine (IsOdd (5)); 
    }
    public static int Add (int firstNumber, int secondNumber) {
        return firstNumber + secondNumber;
    }

    public static bool IsOdd (int value) {
        return value % 2 == 1;
    }
}
