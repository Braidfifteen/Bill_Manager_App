using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class AddBillScreen : Screen
    {
        public AddBillScreen()
        {
            output = new AddBillScreenOutput();
            input = new AddBillScreenInput();
        }
    }

    class AddBillScreenOutput : IOutput
    {
        public void Print()
        {
            Console.WriteLine("Add Bill Screen.");
        }
    }

    class AddBillScreenInput : Input
    {
        public AddBillScreenInput()
        {
            validKeys.Add(new EscapeKey(new QuitApplicationCommand()));
            validKeys.Add(new F12Key(new ChangeToDefaultScreenCommand()));
        }
    }
}
