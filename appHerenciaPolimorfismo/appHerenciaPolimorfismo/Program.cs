using System;

namespace appHerenciaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que empiece el juego");
            Lavadora lavadora = new Lavadora
            {
                Marca = "LG",
                Modelo = "Vzde234",
                Precio = 488,
                Color = "Blanco",
                Capacidad = "20kg"
            };
            Console.WriteLine(lavadora.Id);
        }
    }
}
