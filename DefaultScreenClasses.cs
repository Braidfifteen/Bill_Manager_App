using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class DefaultScreen : Screen
    {
        public DefaultScreen()
        {
            input = new DefaultScreenInput();
            output = new DefaultScreenOutput(input);

        }
    }

    class DefaultScreenOutput : IOutput
    {
        private IOutput optionScreen;

        public DefaultScreenOutput(Input input)
        {
            optionScreen = new ScreenOptions(input);
        }

        public void Print()
        {
            optionScreen.Print();
            Console.WriteLine("This is the default screen.");
            Console.WriteLine();
            printAllBills();
        }

        private void printAllBills()
        {
            foreach (BillData bill in BillDatabase.Instance.Database)
            {
                bill.PrintBill();
            }
        }
    }

    class DefaultScreenInput : Input
    {
        public DefaultScreenInput()
        {
            validKeys.Add(new EscapeKey(new QuitApplicationCommand(), "Quit"));
            validKeys.Add(new EnterKey(new ChangeToAddBillScreenCommand(), "Add Bill"));
        }
    }
}
