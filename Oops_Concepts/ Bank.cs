// ABSTRACTION 
// is a process in which we focus display only necessary things and hide unnecessary objects
// in other words hide implementation details from user and display only essential features

using System;

namespace Oops_Concepts
{
    public class Bank
    {
        private int _pin;
        private string _AccountHolderName;
        public int AccountNumber = 1234567;
        
        public int pin { get { return _pin; } set { _pin = value; } }

        public string AccountHolderName { get { return _AccountHolderName; } 
               set { _AccountHolderName = value; } }
  
         // display because its necessary and public
          public void display() 
        {

            Console.WriteLine("Customer Details name ="+ AccountHolderName+  
                     "And account number = " + AccountNumber );
        }
        
        // private doesnt show its unnecessary
        private void Displaypin() 
        {
            Console.WriteLine("pin of customer");
        }

    }
}