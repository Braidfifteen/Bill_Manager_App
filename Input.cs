using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager_App
{
    abstract class Input
    {
        protected List<InputKey> validKeys;
        private InputKey pressedKey;

        protected Input()
        {
            validKeys = new List<InputKey>();
        }

        public ICommand InputCommand { get { return pressedKey.KeyCommand; } }

        public void HandleInput()
        {
            pressedKey = null;
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                for (int i = 0; i < validKeys.Count; i++)
                {
                    if (validKeys[i].Key == key.Key)
                    {
                        pressedKey = validKeys[i];
                        break;
                    }
                }
            }
            while (pressedKey == null);
        }
    }
}
