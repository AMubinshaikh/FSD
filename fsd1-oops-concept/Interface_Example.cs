/*
 interface is used to overcome multiple inheritance when we inherits two classes into one 
 LIKE class a : b,c
 there are chances of ambiguity 
 hence interface can use to reduce duplication of property
 when declaring an interface we have to use "interface" keyword
 in interface thers is only method declarations but no implementations we can say method without body
 we can implement all interface methods in any class just implement that interface
 but you have to implement all the methods of interface 
 if you try to use some of methos it will show complilation error 
 below is an example of interface
 we can implement more than one interface
*/
using System;
namespace fsd1_oops_concept {
    public interface ICoachingCentre {
        public void DisplaySubjects ();
        public void SelectedSubject ();
        public void CalculateFees ();
        public void PrintFeeReceipt ();
    }
    public class MsTutorials : ICoachingCentre {
        public void CalculateFees () {
            Console.WriteLine ("calculating fees MsTutorials");
        }

        public void DisplaySubjects () {
            Console.WriteLine ("Your selected subject MsTutorials");
        }

        public void PrintFeeReceipt () {
            Console.WriteLine ("fees receipt MsTutorials");
        }

        public void SelectedSubject () {
            Console.WriteLine ("MsTutorials subject name\n english\n french\n science");
        }
    }
    public class abcClasses : ICoachingCentre {
        public void CalculateFees () {
            Console.WriteLine ("calculating fees abcClasses");
        }

        public void DisplaySubjects () {
            Console.WriteLine ("Your selected subject abcClasses");
        }

        public void PrintFeeReceipt () {
            Console.WriteLine ("fees receipt abcClasses");
        }

        public void SelectedSubject () {
            Console.WriteLine ("abcClasses subject name\n english\n french\n science ");
        }
    }

    public class Interface_Example {
        public static void Main (string[] args) {
            MsTutorials ms = new MsTutorials ();
            abcClasses abc = new abcClasses ();

            ms.DisplaySubjects ();
            ms.SelectedSubject ();
            ms.CalculateFees ();
            ms.PrintFeeReceipt ();

            abc.DisplaySubjects ();
            abc.SelectedSubject ();
            abc.CalculateFees ();
            abc.PrintFeeReceipt ();
        }
    }
}