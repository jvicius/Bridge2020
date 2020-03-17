using System;

namespace BridgeDemoConsole.Models
{
    public class Circulo : Figuras
    {
        public override void PintarFigura()
        {
            //https://www.csharp-console-examples.com/general/draw-a-circle-in-c-console-application/
            Color.Pintar();
            double radius = 5;
            double thickness = 0.4;
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
