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
            key = ConsoleKey.Enter;
        }
    }

    class F12Key : InputKey
    {
        public F12Key(ICommand command) : base(command)
        {
            key = ConsoleKey.F12;
        }
    }

    class EscapeKey : InputKey
    {
        public EscapeKey(ICommand command) : base(command)
        {
            key = ConsoleKey.Escape;
        }
    }
}
