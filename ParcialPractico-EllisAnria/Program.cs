namespace ParcialPractico_EllisAnria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura[] figuras = new Figura[3];

            figuras[0] = new Rectangulo { Base = 5, Altura = 10 };
            figuras[1] = new Cuadrado { Lado = 4 };
            figuras[2] = new Triangulo { Base = 6, Altura = 8, Lado = 5 };
            
            foreach (Figura figura in figuras)
            {
                Console.WriteLine($"Figura: {figura.GetType().Name}");
                Console.WriteLine($"Área: {figura.CalcularArea()}");
                Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()}");
                Console.WriteLine();
            }

        }
    }
}
