using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class Bank
    {


        public static double _balance = 5000.00;



        public static void Withdraw(double amount)
        {


            bool isValidWithdrawalTransaction = ValidationDecorator.ValidateWithdraw(amount,_balance);
            if(isValidWithdrawalTransaction==false)
            {
                SystemMessages.ExitApp();
            }
            else
            {
                double oldbalance = _balance;

                double newbalance = _balance - amount;

                _balance = _balance - amount;

                LoggingDecorator.LogTransactionDetails(amount, oldbalance, newbalance, "WITHDRAW", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                
            }

        }

        public static void Deposit(double amount)
        {
            bool isValidDepositTransaction = ValidationDecorator.ValidateDeposit(amount, _balance);
            if (isValidDepositTransaction == false)
            {
                SystemMessages.ExitApp();
            }
            else
            {
                double oldbalance = _balance;

                double newbalance = _balance + amount;

                _balance = _balance + amount;

                LoggingDecorator.LogTransactionDetails(amount, oldbalance, newbalance, "DEPOSIT", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            }

        }





    }
}
