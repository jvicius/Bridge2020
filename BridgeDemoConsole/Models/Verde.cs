using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemoConsole.Models
{
    public class Verde : IColor
    {
        public void Pintar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
