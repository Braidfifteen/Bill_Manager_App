using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    abstract class Screen
    {
        protected IOutput output;
        protected Input input;
        private ICommand inputCommand;

        public void GetInput()
        {
            input.HandleInput();
        }

        public void PrintScreen()
        {
            Console.Clear();
            output.Print();
        }

        public void Update()
        {
            inputCommand = input.InputCommand;
            inputCommand.Execute();
        }

        private void getNextCommand()
        {
            inputCommand = input.InputCommand;
        }
    }
}
