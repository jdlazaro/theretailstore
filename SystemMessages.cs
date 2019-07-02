using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class SystemMessages
    {

        public static void IntroductionMessage()
        {

            Console.WriteLine("Welcome to my simple bank transaction app!");
            Console.WriteLine("Instructions : ");
            Console.WriteLine("Enter action followed by amount. 'WITHDRAW 2000'");
            Console.WriteLine("Actions <WITHDRAW> OR <DEPOSIT> ");
            Console.WriteLine("Enter below ");


        }

        public static void ExitApp()
        {
            Console.ReadLine();
        }


        public static void ShowErrorMessage()
        {


        }
        public static void ShowCommandMessage()
        {
            Console.WriteLine("TO CONTINUE - PLEASE PRESS ENTER AND WRITE THE COMMAND <DEPOSIT> OR <WITHDRAW> ");

        }

        public static void ShowMessage(String message)
        {

            Console.WriteLine(message);

        }

    }
}
