//INTERFACE example
using System;
namespace Oops_Concepts
{
   public class MSTutorials : ICoachingCentre
    {
    public void CalculateFees()
    {
        Console.WriteLine("calculating fees MsTutorials");
    }

    public void DisplaySubjects()
    {
        Console.WriteLine("Your selected subject MsTutorials");
    }

    public void PrintFeeReceipt()
    {
         Console.WriteLine("fees receipt MsTutorials");
    }

    public void SelectedSubject()
    {
        Console.WriteLine("MsTutorials subject name\n english\n french\n science");
    }
}

}