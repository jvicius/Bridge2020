using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemoConsole.Models
{
    public class Azul : IColor
    {
        public void Pintar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
