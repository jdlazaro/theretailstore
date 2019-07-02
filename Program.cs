using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyExam
{

    public class Program
    {

        public static bool IsExit = false;
        static void Main(string[] args)
        {

            SystemMessages.IntroductionMessage();



            while(IsExit==false)
            {


                string input = Console.ReadLine();

                string[] inputArray = input.Trim().Split(new Char[] { ' ', '\n' });


                String cmd = "";
                String amount_enter = "";

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i == 0)
                    {
                        cmd = inputArray[0].ToString();
                    }
                    else
                    {
                        amount_enter = inputArray[1].ToString();
                    }
                }






                Bank bank = new Bank();

                ICommand cmdWithdraw = new Commands.WithdrawCommand(bank);

                ICommand cmdDeposite = new Commands.DepositCommand(bank);

                Invoker invoker = new Invoker();

                if (cmd == "WITHDRAW")
                {


                    invoker.amount = Convert.ToDouble(amount_enter);
                    invoker.StoreAndExecute(cmdWithdraw);



                }
                else if (cmd == "DEPOSIT")
                {

                    invoker.amount = Convert.ToDouble(amount_enter);
                    invoker.StoreAndExecute(cmdDeposite);



                }
                else
                {

                    Console.WriteLine("INVALID COMMAND");
                    Console.WriteLine("PLEASE ENTER COMMAND <DEPOSIT> OR <WITHDRAW>");
                }

            } //end while




        }











    }
}
