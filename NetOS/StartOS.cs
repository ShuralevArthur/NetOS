using System;
using System.Collections.Generic;
using System.Text;

namespace NetOS
{
    class StartOS
    {
        public static void SetStyle()
        {
            Cosmos.HAL.TextScreen textScreen = new Cosmos.HAL.TextScreen();
            textScreen.Background = ConsoleColor.White;
            textScreen.Foreground = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            textScreen.Clear();
        }

        public static void Welcome()
        {
            SystemOut.DefaultPrint("Welcome to NetOS");
            SystemOut.DefaultPrint("Print Help to get help with OS commands");
        }
    }
}
