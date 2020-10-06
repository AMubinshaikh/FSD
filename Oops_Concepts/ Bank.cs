// ABSTRACTION 
// is a process in which we focus display only necessary things and hide unnecessary objects
// in other words hide implementation details from user and display only essential features

using System;

namespace Oops_Concepts
{
    public class Bank
    {
        private int pinNumber;
        private string accountHolderName;
        public int accountNumber = 1234567;
        
        public int pinNumberAccess {
          get { return pinNumber; } 
          set { pinNumber = value; } }

        public string accountHolderNameAccess {
            get { return accountHolderName; } 
            set { accountHolderName = value; } }
  
         // display because its necessary and public
          public void DisplayPersonalDetails() 
        {

            Console.WriteLine("Customer Details name ="+ accountHolderNameAccess+  
                     "And account number = " + accountNumber );
        }
        
        // private doesnt show its unnecessary
        private void DisplayPin() 
        {
            Console.WriteLine("pin of customer");
        }

    }
}