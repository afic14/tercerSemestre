using System;
using System.Collections.Generic;
using System.Data;

namespace facturaHotel
{
    class Program
    {
        public string saludo()
        {
            return "hola";
        }
        public void AgregarCliente()
        {

        }
        static void Main(string[] args)
        {
            string cedulaPersona;
            string nombrePersona;
            string apellidoPersona;
            string celularPersona;
            DateTime fecha = DateTime.Today;
            Cliente cliente = new Cliente();
            Recepcionista recepcionista = new Recepcionista();
            Habitación habitacion = new Habitación();
            Factura factura = new Factura();
            List<Factura> listafactura = new List<Factura>();
            List<Habitación> listaHabitacion = new List<Habitación>();
            List<Recepcionista> listaRecepcionista = new List<Recepcionista>();
            List<Persona> persona = new List<Persona>();

            Console.WriteLine("Bienvenido");
            //Cliente
            Console.WriteLine("Ingrese los datos un cliente");
            Console.WriteLine("Ingrese la cedula");
            cedulaPersona = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre");
            nombrePersona = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            apellidoPersona = Console.ReadLine();
            Console.WriteLine("Ingrese el celular");
            celularPersona = Console.ReadLine();
            var newCliente = cliente.AgregarPersona(cedulaPersona, nombrePersona, apellidoPersona, celularPersona);
            //
            //Recepcionista
            Console.WriteLine("Ingrese los datos un recepcionista");
            Console.WriteLine("Ingrese la cedula");
            var cedulaRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre");
            var nombreRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            var apellidoRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingrese el celular");
            var celularRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            var sueldoRecepcionista = Console.ReadLine();
            var newRecepcionista = recepcionista.AgregarPersonal(cedulaRecepcionista, nombreRecepcionista, apellidoRecepcionista, celularRecepcionista, sueldoRecepcionista);
            //
            //Habitación
            Console.WriteLine("Ingrese los datos una habitación");
            Console.WriteLine("Ingrese el código");
            var códigoHabitación = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de camas");
            var numeroCamasHabitación = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            var precioHabitación = Console.ReadLine();
            var newHabitacion = habitacion.agregarHabitación(códigoHabitación, numeroCamasHabitación, precioHabitación);
            //
            //Factura
            Console.WriteLine("Ingrese los datos una factura");
            Console.WriteLine("Ingrese el código");
            var códigoFactura = Console.ReadLine();
            var newFactura = factura.CrearFactura(códigoFactura, fecha);
            //listafactura.Add(newFactura);
            factura.Cliente = newCliente;
            factura.Recepcionista = newRecepcionista;
            factura.Habitación = newHabitacion;
            //añadir a las listas
            persona.Add(newCliente);
            listaRecepcionista.Add(newRecepcionista);
            listaHabitacion.Add(newHabitacion);
            listafactura.Add(newFactura);
            //Console.WriteLine(persona[0].Cedula);
            //Console.WriteLine("Presione una tecla");
            //var tecla = Console.ReadKey();
            //Console.WriteLine(tecla.Key);
            //var comprobarTecla = tecla.Key;
            /*switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("nada aqui");
                    break;
                case "B":
                    Console.WriteLine("aqui tampoco");
                    break;
                
            }*/

        }
    }
}
