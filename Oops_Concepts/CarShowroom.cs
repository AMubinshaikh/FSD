 //Encapsulation
//is a process in which we can hide data from external function and 
//external cannot access private member
//in this example some member are public and some are private.
using System;
namespace Oops_Concepts
{
    public class CarShowroom
    {
      private int CarKeyCodeAccess;
      private string engineCode;
      public string carModel;
      public string carMake;
      private void CarEncryptDisplay()
      {
      Console.WriteLine("Encrypted Display");
      }

      public void GetBasicDetails(string carMakeParam , string carModelParam)
      {
      carMake = carMakeParam;
      carModel = carModelParam;
      }
    
      public void DisplayCarDetails()
      {
      Console.WriteLine("Make = " + carMake + " Model = " + carModel);
      }
      public int carKeyCodeAccess{
         get { return carKeyCodeAccess; } 
         set { carKeyCodeAccess = value; } }   
      public string EngineCode {
         get { return EngineCode; } 
         set { EngineCode = value; } }
    
    }
}