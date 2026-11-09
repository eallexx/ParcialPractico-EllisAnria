using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialPractico_EllisAnria
{
    public class Rectangulo: Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }


        public override int CalcularArea()
        {
            return Base * Altura;
        }

        public override int CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }


    }
}
