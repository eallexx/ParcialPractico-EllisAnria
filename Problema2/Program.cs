using Newtonsoft.Json;
namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new
            {
                Nombre = "Ellis",
                Edad = 21,
                Carrera = "Ingenieria en sistemas"
            };



            string json = JsonConvert.SerializeObject(persona);
            Console.WriteLine(json);
        }
    }
}
