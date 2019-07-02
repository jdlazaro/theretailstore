using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class Invoker
    {

        private List<ICommand> _commands = new List<ICommand>();

        public double amount;

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute(amount);



        }

    }
}
