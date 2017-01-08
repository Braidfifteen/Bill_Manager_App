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
        private ICommand keyCommand;

        protected InputKey(ICommand command)
        {
            keyCommand = command;
        }

        public ConsoleKey Key { get { return key; } }
        public ICommand KeyCommand { get { return keyCommand; } }
    }
}
