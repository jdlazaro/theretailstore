using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class ValidationDecorator : Bank
    {

        protected Bank bank;

        public ValidationDecorator(Bank bank)
        {

            this.bank = bank;
        }


        public static bool ValidateWithdraw(double amount, double balance)
        {

            if (amount > balance)
            {

                SystemMessages.ShowMessage("Withdrawal amount should not be more than the current balance.");
                SystemMessages.ShowCommandMessage();
                return false;
            }
            else
            {
                if (amount < 300)
                {

                    SystemMessages.ShowMessage("Unable to process transaction. 300 is minimum withdrawal amount");
                    SystemMessages.ShowCommandMessage();

                    return false;
                }
                else if (amount > 10000)
                {

                    SystemMessages.ShowMessage("Unable to process transaction. 10,000 is maximum withdrawal amount");
                    SystemMessages.ShowCommandMessage();

                    return false;
                }
            }




            SystemMessages.ShowCommandMessage();

            return true;
        }



        public static bool ValidateDeposit(double amount, double balance)
        {

            if (amount < 1000)
            {

                SystemMessages.ShowMessage("Unable to process transaction. Minimum deposit amount is 1,000");
                SystemMessages.ShowCommandMessage();

                return false;
            } 
            else if (amount > 50000)
            {
                SystemMessages.ShowMessage("Unable to process transaction. Maximum deposit amount is 50,000");

                SystemMessages.ShowCommandMessage();

                return false;
            }

            SystemMessages.ShowCommandMessage(); 
            return true;
        }






    }
}
