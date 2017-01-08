using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class MainLoop
    {
        private bool isRunning = true;
        private Screen currentScreen;
        private static MainLoop instance;

        private MainLoop()
        {
            // For Testing
            BillData testBill = new BillData("Test Bill", 43.20);
            BillDatabase.Instance.AddBill(testBill); 

            currentScreen = new DefaultScreen();
        }

        public static MainLoop Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainLoop();
                return instance;
            }
        }

        public void Run()
        {
            runMainLoop();
        }

        public void ChangeScreen(Screen s)
        {
            currentScreen = s;
        }

        public void Quit()
        {
            isRunning = false;
        }

        private void runMainLoop()
        {
            while (isRunning)
            {
                currentScreen.PrintScreen();
                currentScreen.GetInput();
                currentScreen.Update();
            }
        }
    }
}
