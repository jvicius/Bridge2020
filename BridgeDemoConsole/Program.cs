using System;
using BridgeDemoConsole.Models;

namespace BridgeDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var res1 = MenuFigura();
            var res2 = MenuColor();

            Figuras figura=null;
            IColor color = null;

            switch (res1)
            {
                case 1: 
                    figura = new Circulo();
                    break;
                case 2:
                    figura = new Cuadrado();
                    break;
                case 3:
                    figura = new Rectangulo();
                    break;
            }

            switch (res2)
            {
                case 1:
                    color = new Verde();
                break;
                case 2:
                    color = new Azul();
                    break;
                case 3:
                    color = new Rojo();
                    break;
            }

            Console.Clear();
            figura.Color = color;
            figura.PintarFigura();
        }

        public static int MenuFigura()
        {
            var result= -1;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Rectangulo");
                var keyValue = Console.ReadKey();
                if (char.IsDigit(keyValue.KeyChar))
                {
                    result = Int32.Parse(keyValue.KeyChar.ToString());
                    if (result == 1 || result == 2 || result == 3)
                        return result;
                }
            }
        }

        public static int MenuColor()
        {
            var result = -1;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("1. Verde");
                Console.WriteLine("2. Azul");
                Console.WriteLine("3. Rojo");
                var keyValue = Console.ReadKey();
                if (char.IsDigit(keyValue.KeyChar))
                {
                    result = Int32.Parse(keyValue.KeyChar.ToString());
                    if (result == 1 || result == 2 || result == 3)
                        return result;
                }
            }
        }
    }
}
