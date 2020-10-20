using System;
using System.Collections.Generic;
using System.Text;

namespace NetOS
{
    class SystemOut
    {
        static public void PrintLine(String text) => Console.WriteLine($"> {text}");
        static public void Print(String text) => Console.Write($"> {text}");
        static public void DefaultPrint(String text) => Console.WriteLine(text);
        static public void ErrorPrint(String text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"   {text} \n");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
