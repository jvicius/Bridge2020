using System;

namespace BridgeDemoConsole.Models
{
    public class Rojo : IColor
    {
        public void Pintar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
