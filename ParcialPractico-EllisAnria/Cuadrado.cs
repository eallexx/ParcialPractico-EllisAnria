using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPractico_EllisAnria
{
    public class Cuadrado: Figura
    {
        public int Lado { get; set; }


        public override int CalcularArea()
        {
            return Lado * Lado;
        }

        public override int CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
