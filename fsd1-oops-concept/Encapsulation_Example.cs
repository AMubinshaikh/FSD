 /*
  //Encapsulation
 //is a process in which we can hide data from external function and 
 //external cannot access private member
 //in this example some member are public and some are private.
 */
 using System;
 namespace fsd1_oops_concept {
     public class Car {
         private int _CarKeyCode;
         private string _EngineCode;
         public string _carModel;
         public string _carMake;
         private void CarEncryptDisplay () {
             Console.WriteLine ("Encrypted Display");
         }

         public void GetBasicDetails (string a, string b) {
             _carMake = a;
             _carModel = b;
         }

         public void print () {
             Console.WriteLine ("Make = " + _carMake + " Model = " + _carModel);
         }
         public int CarKeyCode {

             get {
                 return _CarKeyCode;
             }
             set {
                 _CarKeyCode = value;
             }
         }
         public string EngineCode {

             get {
                 return _EngineCode;
             }
             set {
                 _EngineCode = value;
             }
         }
     }
     public class Encapsulation_Example {
         public static void Main (string[] args) {
             Car c = new Car ();
             c.CarKeyCode = 12345; // we can access private feild using getter and setter accessor
             c.EngineCode = "E4598GHF";
             Console.WriteLine ("Car Key Code = " + c.CarKeyCode);
             Console.WriteLine ("Car Engine Code = " + c.EngineCode);
             c.GetBasicDetails ("honda", "city");
             c.print ();
             // c.CarEncryptDisplay(); // is inaccessible due to its protection level

         }
     }
 }