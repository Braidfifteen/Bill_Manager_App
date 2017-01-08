using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class EnterKey : InputKey
    {

        public EnterKey(ICommand command) : base(command)
        {
            initSelf();
        }

        public EnterKey(ICommand command, string cmdDes) : base(command, cmdDes)
        {
            initSelf();
        }

        private void initSelf()
        {
            key = ConsoleKey.Enter;
            name = "Enter";
        }
    }

    class F12Key : InputKey
    {
        public F12Key(ICommand command) : base(command)
        {
            initSelf();
        }

        public F12Key(ICommand command, string cmdDes) : base(command, cmdDes)
        {
            initSelf();
        }

        private void initSelf()
        {
            key = ConsoleKey.F12;
            name = "F12";
        }
    }

    class EscapeKey : InputKey
    {
        public EscapeKey(ICommand command) : base(command)
        {
            initSelf();
        }

        public EscapeKey(ICommand command, string cmdDes) : base(command, cmdDes)
        {
            initSelf();
        }

        private void initSelf()
        {
            key = ConsoleKey.Escape;
            name = "Escape";
        }
    }
}
