
using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingleInheritnce 
            Teacher teacher = new Teacher(); 
            Console.WriteLine("Roll Number: " + teacher.rollNumber);  
            Console.WriteLine("Percentage: " + teacher.percentage);  
            //-----------------------------------------------------------

            //we are going to create only derived class object and can access all base class member
             // resultClass class is derived class
             ResultClass resultClass = new ResultClass(); 
             resultClass.printName();
             resultClass.printResult();
            //-------------------------------------------------------------

            AddingNumbers addingNumbers  = new AddingNumbers();  

             // calling Add Function by using
             //class name because Add is an Static type function 
             
             int number1,number2,number3;
             Console.WriteLine("Enter Two Numbers");
             number1 = Convert.ToInt32(Console.ReadLine());
             number2 = Convert.ToInt32(Console.ReadLine());
             // calling function with class name because first function is static type function
             Console.WriteLine("The sum of two Number is = " + AddingNumbers.AddNumbers(number1,number2)); 

             
            // calling function with object because second function is not static type function
             
             Console.WriteLine("Enter three Numbers");
             number1 = Convert.ToInt32(Console.ReadLine());
             number2 = Convert.ToInt32(Console.ReadLine());
             number3 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("The sum of two Number is = " 
                + addingNumbers.AddNumbers(number1,number2,number3)); 

            //------------------------------------------------------------------    
           
            
              OverridingClass baseobject = new OverridingClass();
              // base class print method calls
              baseobject.print(); 

              child derivedobject = new child();
              // dervied class print method calls
              derivedobject.print(); 

              //---------------------------------------------------------------

            CarShowroom carShowroom = new CarShowroom();
             // we can access private feild using getter and setter accessor
            carShowroom.CarKeyCode = 12345;
            carShowroom.EngineCode = "E4598GHF";
            Console.WriteLine("Car Key Code = " + carShowroom.CarKeyCode);
            Console.WriteLine("Car Engine Code = " + carShowroom.EngineCode);
            carShowroom.GetBasicDetails("honda","city");
            carShowroom.print();
            //is inaccessible due to its protection level
            //carShowroom.CarEncryptDisplay(); 

            Bank bank = new Bank();
            bank.AccountHolderName = "zubinshaikh";
            // accessible and no error
            bank.display(); 
             //  inaccesible because it is private
            // bank.displayPin();

            MSTutorials msTutorials = new MSTutorials();
            MaheshTutorials maheshTutorials = new MaheshTutorials();

            msTutorials.DisplaySubjects();
            msTutorials.SelectedSubject();
            msTutorials.CalculateFees();
            msTutorials.PrintFeeReceipt();

            maheshTutorials.DisplaySubjects();
            maheshTutorials.SelectedSubject();
            maheshTutorials.CalculateFees();
            maheshTutorials.PrintFeeReceipt();
                
       }
    }
}

