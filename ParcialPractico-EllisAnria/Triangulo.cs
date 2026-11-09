using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPractico_EllisAnria
{
    public class Triangulo: Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Lado { get; set; }

        public override int CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override int CalcularPerimetro()
        {
            
            return 3 * Lado;
        }
    }
}
