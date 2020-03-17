using System;

namespace BridgeDemoConsole.Models
{
    public abstract class Figuras
    {
        public IColor Color;
        public abstract void PintarFigura();
    }
}
