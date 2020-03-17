using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemoConsole.Models
{
    public class Cuadrado : Figuras
    {
        public override void PintarFigura()
        {
            Color.Pintar();
            Console.WriteLine("************");
            Console.WriteLine("*          *");
            Console.WriteLine("*          *");
            Console.WriteLine("*          *");
            Console.WriteLine("*          *");
            Console.WriteLine("************");
        }
    }
}
