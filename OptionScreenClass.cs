using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    class ScreenOptions : IOutput
    {
        private Input screenValidInput;

        public ScreenOptions(Input input)
        {
            this.screenValidInput = input;
        }

        public void Print()
        {
            foreach (InputKey key in screenValidInput.ValidKeys)
            {
                Console.WriteLine("{0} to {1}", key.Name, key.CommandDescription);
            }
        }
    }
}
