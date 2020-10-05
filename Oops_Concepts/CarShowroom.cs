 //Encapsulation
//is a process in which we can hide data from external function and 
//external cannot access private member
//in this example some member are public and some are private.
using System;
namespace Oops_Concepts
{
    public class CarShowroom
    {
    private int _CarKeyCode;
    private string _EngineCode;
    public string _carModel;
    public string _carMake;
    private void CarEncryptDisplay()
    {
      Console.WriteLine("Encrypted Display");
    }

    public void GetBasicDetails(string carMake , string carModel)
    {
      _carMake = carMake;
      _carModel = carModel;
    }
    
    public void print()
    {
      Console.WriteLine("Make = " + _carMake + " Model = " + _carModel);
    }
    public int CarKeyCode{ get { return _CarKeyCode; } set { _CarKeyCode = value; } }   
    public string EngineCode { get { return _EngineCode; } set { _EngineCode = value; } }
    
    }
}