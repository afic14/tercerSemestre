using System;

namespace AppLavadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string marca;
            string modelo;
            string capacidad;
            string color;

            Console.WriteLine("Empezemos la simulacion de guardado de Lavadoras");
            Console.WriteLine("Escribe la marca de tu lavadora");
            marca = Console.ReadLine();
            Console.WriteLine("Escribe el modelo de tu lavadora");
            modelo = Console.ReadLine();
            Console.WriteLine("Escribe la capacidad de tu lavadora");
            capacidad = Console.ReadLine();
            Console.WriteLine("Escribe el color de tu lavadora");
            color = Console.ReadLine();
            Console.WriteLine("Pulsa cualquier tecla para ver la información de tu lavadora");
            Console.ReadKey();
            Console.WriteLine();
            var lavadora = new Lavadora(marca, modelo, capacidad, color);
            Console.WriteLine($"Marca: {lavadora.Marca}, Modelo: {lavadora.Modelo}, " +
                $"Capacidad: {lavadora.Capacidad}, Color: {lavadora.Color}");
            Console.WriteLine("Ahora vamos a empezar a testear la lavadora");
            Console.WriteLine("Pulsa cualquier tecla para encender de tu lavadora");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(lavadora.Encender());
            Console.WriteLine("Muy bien, ahora escribe el tiempo que deseas que lave");
            var tiempoL = Console.ReadLine();
            Console.WriteLine(lavadora.Lavar(tiempoL));
            Console.WriteLine("Lavando......");
            Console.WriteLine("He acabado de lavar, ahora voy a secar");
            Console.WriteLine("Escribe por cuanto tiempo quieres que seque");
            var tiempoS = Console.ReadLine();
            Console.WriteLine(lavadora.Secar(tiempoS));
            Console.WriteLine("Secando...");
            Console.WriteLine("Muy bien ya termine de secar, ahora es tiempo de despedirse");
            Console.WriteLine("Pulsa cualquier tecla para apagar");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(lavadora.Apagar());
        }
    }
}
