using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    abstract class InputKey
    {
        protected ConsoleKey key;
        protected string commandDescription = String.Empty;
        protected string name = String.Empty;
        private ICommand keyCommand;

        protected InputKey(ICommand command, string cmdDescription)
        {
            keyCommand = command;
            commandDescription = cmdDescription;
        }

        protected InputKey(ICommand command)
        {
            keyCommand = command;
        }

        public string CommandDescription { get { return commandDescription; } }
        public string Name { get { return name; } }
        public ConsoleKey Key { get { return key; } }
        public ICommand KeyCommand { get { return keyCommand; } }
    }
}
