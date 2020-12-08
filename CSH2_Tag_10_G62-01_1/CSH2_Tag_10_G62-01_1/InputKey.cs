using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_G62_01_1
{
    static class InputKey
    {
        public delegate void InputEventHandler(char c);
        public static event InputEventHandler InputEvent;

        public static void TasteAbfragen()
        {
            Console.CursorVisible = false;
            ConsoleKey ck = ConsoleKey.NoName;

            while (ck != ConsoleKey.Escape)
            {
                if (Console.KeyAvailable)
                {
                    ck = Console.ReadKey(true).Key;
                    InputEvent?.Invoke((char)ck);
                }
            }
        }
    }
}
