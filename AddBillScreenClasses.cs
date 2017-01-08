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
            input = new AddBillScreenInput();
            output = new AddBillScreenOutput(input);
        }
    }

    class AddBillScreenOutput : IOutput
    {
        private ScreenOptions screenOptions;

        public AddBillScreenOutput(Input input)
        {
            screenOptions = new ScreenOptions(input);
        }

        public void Print()
        {
            screenOptions.Print();
            Console.WriteLine("Add Bill Screen.");
        }
    }

    class AddBillScreenInput : Input
    {
        public AddBillScreenInput()
        {
            validKeys.Add(new EscapeKey(new QuitApplicationCommand(), "Quit"));
            validKeys.Add(new F12Key(new ChangeToDefaultScreenCommand(), "Previous Screen"));
        }
    }
}
