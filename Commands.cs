using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class Commands
    {

        public class DepositCommand : ICommand
        {

            private Bank _bank;

            public DepositCommand(Bank bank)
            {
                _bank = bank;
            }

            public void Execute(Double amount)
            {
                Bank.Deposit(amount);
            }



        }



        public class WithdrawCommand : ICommand
        {

            private Bank _bank;

            public WithdrawCommand(Bank bank)
            {
                _bank = bank;
            }

            public void Execute(Double amount)
            {
                Bank.Withdraw(amount);
            }


        }

    }
}
