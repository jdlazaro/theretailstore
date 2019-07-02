using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class LoggingDecorator
    {

        public static void LogTransactionDetails(double amount,double oldbalance, double newbalance, string action, string transdate)
        {

            if(action == "WITHDRAW")
            {
                Console.WriteLine("***************************");
                Console.WriteLine("***************************"); 
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine(" ");
                Console.WriteLine(" "); 
                Console.WriteLine("Withdrawal Details : "); 
                Console.WriteLine(" "); 
                Console.WriteLine("Before Transaction Balance  = " + oldbalance.ToString());
                Console.WriteLine("Withdrawal Amount  = " + amount.ToString());
                Console.WriteLine("Current Transaction Balance  = " + newbalance.ToString()); 
                Console.WriteLine("Date of Transaction  = " + transdate.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(" "); 
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
            }
            else
            {
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Deposit Details : ");
                Console.WriteLine(" ");
                Console.WriteLine("Before Transaction Balance  = " + oldbalance.ToString());
                Console.WriteLine("Deposit Amount  = " + amount.ToString());
                Console.WriteLine("Current Transaction Balance  = " + newbalance.ToString()); 
                Console.WriteLine("Transaction Date  = " + transdate.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
                Console.WriteLine("***************************");
            }

            SystemMessages.ShowCommandMessage();

            Console.ReadLine();

        }


    }
}
