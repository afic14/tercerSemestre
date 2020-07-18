using System;

namespace facturaHotel
{
    class Program
    {
        public string saludo()
        {
            return "hola";
        }
        static void Main(string[] args)
        {
            string cedulaPersona;
            string nombrePersona;
            string apellidoPersona;
            Cliente cliente = new Cliente();

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese los datos un usuario");
            Console.WriteLine("Ingrese la cedula");
            cedulaPersona = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre");
            nombrePersona = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            apellidoPersona = Console.ReadLine();
            cliente.AgregarPersona(cedulaPersona, nombrePersona, apellidoPersona);
            Console.WriteLine();
        }
    }
}
