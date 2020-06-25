using System;

namespace AppPrimerTarea
{
    class Lavadora
    {
        public string marca;
        public string modelo;
        public string capacidad;
        public string color;
        public void Encender()
        {

            Console.WriteLine("Encendindo...");

        }
        public void Apagar()
        {

            Console.WriteLine("Apagando...");

        }
        public void Lavar()
        {

            Console.WriteLine("Ingrese los minutos que desea lavar");
            string tiempo;
            tiempo = Console.ReadLine();

            Console.WriteLine("La lavadora estará lavando durante " + tiempo + "minutos");
        }
        public void Secar()
        {

            Console.WriteLine("Ingrese los minutos que desea secar");
            string tiempo;
            tiempo = Console.ReadLine();

            Console.WriteLine("La lavadora estará secando durante " + tiempo + "minutos");
        }
        static void Main(string[] objeto)
        {
            if (objeto.Length > 0) {
                Console.WriteLine(objeto[0]);
            }
            else
            {
                Console.WriteLine("Comenzaremos con una simulacion de las pruebas de funcionamiento de una lavadora");
            }
            Console.WriteLine("Escribe la marca de tu lavadora");
            string marca = Console.ReadLine();
            Console.WriteLine("Escribe el modelo de tu lavadora");
            string modelo = Console.ReadLine();
            Console.WriteLine("Escribe la capacidad de tu lavadora");
            string capacidad = Console.ReadLine();
            Console.WriteLine("Escribe el color de tu lavadora");
            string color = Console.ReadLine();
            Console.WriteLine("Pulsa cualquier tecla para ver la información de tu lavadora");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Marca:" + marca + "  Modelo:" + modelo + "  Capacidad:" + capacidad + "  Color:" + color);
            Console.WriteLine("Pulsa cualquier tecla para encender de tu lavadora");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Encendiendo....");
            Console.WriteLine("Encendida");
            Console.WriteLine("Pulsa cualquier tecla para empezar a lavar");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Ingrese los minutos que desea que lave");
            string tiempo;
            tiempo = Console.ReadLine();
            Console.WriteLine("La lavadora lavará durante " + tiempo + " minutos");
            Console.WriteLine("Pulsa cualquier tecla para empezar a secar");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Ingrese los minutos que desea que seque");
            string tiempoSecado;
            tiempoSecado = Console.ReadLine();
            Console.WriteLine("La lavadora secará durante " + tiempoSecado + " minutos");
            Console.WriteLine("Pulsa cualquier tecla para apagar de tu lavadora");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Apagando....");
            Console.WriteLine("Fin de la simulación, pulsa cualquier tecla para finalizar el programa");
            Console.ReadKey();
        }
    }
}
