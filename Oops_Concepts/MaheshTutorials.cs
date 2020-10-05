using System;
namespace Oops_Concepts
{
   
public class MaheshTutorials : ICoachingCentre
  {
    public void CalculateFees()
    {
       Console.WriteLine("calculating fees MaheshTutorials");
    }

    public void DisplaySubjects()
    {
       Console.WriteLine("Your selected subject abcClasses");
    }

    public void PrintFeeReceipt()
    {
        Console.WriteLine("fees receipt abcClasses");
    }

    public void SelectedSubject()
    {
       Console.WriteLine("abcClasses subject name\n english\n french\n science ");
    }
    }
}
