using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class QuitApplicationCommand : ICommand
    {
        public void Execute()
        {
            MainLoop.Instance.Quit();
        }
    }

    class ChangeToDefaultScreenCommand : ICommand
    {
        public void Execute()
        {
            MainLoop.Instance.ChangeScreen(new DefaultScreen());
        }
    }

    class ChangeToAddBillScreenCommand : ICommand
    {
        public void Execute()
        {
            MainLoop.Instance.ChangeScreen(new AddBillScreen());
        }
    }

}
