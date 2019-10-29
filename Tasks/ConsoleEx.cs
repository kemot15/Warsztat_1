﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    static class ConsoleEx
    {
        public static void Write (string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteLine (string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
