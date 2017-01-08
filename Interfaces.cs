using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    interface IOutput
    {
        void Print();
    }

    interface ICommand
    {
        void Execute();
    }
}
