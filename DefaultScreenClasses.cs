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
            output = new DefaultScreenOutput();
            input = new DefaultScreenInput();
        }
    }

    class DefaultScreenOutput : IOutput
    {
        public void Print()
        {
            Console.WriteLine("This is the default screen.");
            printAllBills();
        }

        private void printAllBills()
        {
            foreach (BillData bill in BillDatabase.Instance.Database)
            {
                Console.WriteLine(bill.Name);
                Console.WriteLine(bill.MonthlyAmountOwed());
                Console.WriteLine();
            }
        }
    }

    class DefaultScreenInput : Input
    {
        public DefaultScreenInput()
        {
            validKeys.Add(new EscapeKey(new QuitApplicationCommand()));
            validKeys.Add(new EnterKey(new ChangeToAddBillScreenCommand()));
        }
    }
}
