// This is an interface Containing some functions which is not implemented 
//means function declared but without body
//  interface is used to overcome multiple inheritance when we inherits two classes into one 
//  LIKE class a : b,c
//  there are chances of ambiguity 
//  hence interface can use to reduce duplication of property
//  when declaring an interface we have to use "interface" keyword
//  in interface thers is only method declarations but no implementations we can say method without body
//  we can implement all interface methods in any class just implement that interface
//  but you have to implement all the methods of interface 
//  if you try to use some of methos it will show complilation error 
//  below is an example of interface
//  we can implement more than one interface
namespace Oops_Concepts
{
    public interface ICoachingCentre
    {
    
      public void DisplaySubjects();
      public void SelectedSubject();
      public void CalculateFees();
      public void PrintFeeReceipt();
    }
}
