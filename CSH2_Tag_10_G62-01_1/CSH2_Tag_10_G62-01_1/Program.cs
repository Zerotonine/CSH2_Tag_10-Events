using System;

namespace CSH2_Tag_10_G62_01_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Taste drücken! - ESC zum beenden");

            InputKey.InputEvent += InputKey_InputEvent;

            InputKey.TasteAbfragen();
        }

        private static void InputKey_InputEvent(char c)
        {
            Console.WriteLine($"Taste {c} gedrückt!");
        }
    }
}
