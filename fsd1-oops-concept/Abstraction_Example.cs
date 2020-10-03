 /*ABSTRACTION 
 is a process in which we focus display only necessary things and hide unnecessary objects
 in other words hide implementation details from user and display only essential features
 */
 using System;
 namespace fsd1_oops_concept {
     public class AbstractionExample {
         private int _pin;
         private string _AccountHolderName;
         public int acc_no = 1234567;

         public int pin {
             get {
                 return _pin;
             }
             set {
                 _pin = value;
             }
         }

         public string AccountHolderName

         {
             get {
                 return _AccountHolderName;
             }
             set {
                 _AccountHolderName = value;
             }
         }

         public void display () // display because its necessary and public
         {
             Console.WriteLine ("Customer Details name =" + AccountHolderName + "And account number = " + acc_no);
         }

         private void Displaypin () // private doesnt show its unnecessary
         {
             Console.WriteLine ("pin of customer");
         }

     }
     public class Abstraction_Example {
         public static void Main (string[] args) {

             AbstractionExample a = new AbstractionExample ();
             a.AccountHolderName = "zubinshaikh";
             a.display (); // accessible and no error
             // a.displayPin(); //  inaccesible because it is private
         }
     }
 }