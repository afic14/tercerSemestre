using Factura.Interface;
using System;
using System.Collections.Generic;

namespace facturaHotelActualizada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            List<Recepcionista> listaRecepcionistas = new List<Recepcionista>();
            List<Hotel> listaHoteles = new List<Hotel>();
            List<Factur> listaFacturas = new List<Factur>();
            Console.WriteLine("Bienvenido");
            for (var i = 0; i<2; i++)
            {
                Console.WriteLine("Presione a para agregar clientes, b para agregar recepcionistas, c para agregar hoteles, d para agregar facturas o x para salir");
                switch (Console.ReadLine())
                {
                    case "a":
                        Cliente cliente = new Cliente();
                        Console.WriteLine("Comenzemos a ingresar clientes");
                        Console.WriteLine("Escriba el nombre del cliente");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Escriba el apellido del cliente");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Escriba el numero de cedula del cliente");
                        string identificacion = Console.ReadLine();
                        Console.WriteLine("Escriba el celular del cliente");
                        string celular = Console.ReadLine();
                        cliente.Nombre = nombre;
                        cliente.Apellido = apellido;
                        cliente.Identificacion = identificacion;
                        cliente.Celular = celular;
                        listaClientes.Add(cliente);
                        Console.WriteLine("Si desea ver el listado de clientes pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                for (var j = 0; j < listaClientes.Count; j++)
                                {
                                    Console.WriteLine(listaClientes[j].Nombre);
                                }
                            break;
                        }
                        i = 0;
                        break;
                    case "b":
                        Recepcionista recepcionista = new Recepcionista();
                        Console.WriteLine("Comenzemos a ingresar recepcionistas");
                        Console.WriteLine("Escriba el nombre del recepcionista");
                        string nombrer = Console.ReadLine();
                        Console.WriteLine("Escriba el apellido del cliente");
                        string apellidor = Console.ReadLine();
                        Console.WriteLine("Escriba el numero de cedula del cliente");
                        string identificacionr = Console.ReadLine();
                        Console.WriteLine("Escriba el celular del cliente");
                        string celularr = Console.ReadLine();
                        recepcionista.Nombre = nombrer;
                        recepcionista.Apellido = apellidor;
                        recepcionista.Identificacion = identificacionr;
                        recepcionista.Celular = celularr;
                        listaRecepcionistas.Add(recepcionista);
                        i = 0;
                        Console.WriteLine("Si desea ver el listado de recepcionistas pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                for (var j = 0; j < listaRecepcionistas.Count; j++)
                                {
                                    Console.WriteLine(listaRecepcionistas[j].Nombre);
                                }
                                break;
                        }
                        break;
                    case "c":
                        Hotel hotel = new Hotel();
                        Console.WriteLine("Comenzemos a ingresar hoteles");
                        Console.WriteLine("Escriba el nombre del hotel");
                        string nombreh = Console.ReadLine();
                        Console.WriteLine("Escriba el color del hotel");
                        string color = Console.ReadLine();
                        Console.WriteLine("Escriba la direccion del hotel");
                        string direccion = Console.ReadLine();
                        for (var m = 0; m<listaClientes.Count; m++)
                        {
                            Console.WriteLine($"{m+1}: {listaClientes[m].Nombre}");
                        }
                        Console.WriteLine("Escriba el indice del cliente a ingresar");
                        string client = Console.ReadLine();
                        var client1 = int.Parse(client);
                        //hotel.Clientes = listaClientes[client1];
                        hotel.Nombre = nombreh;
                        hotel.Color = color;
                        hotel.Direccion = direccion;
                        listaHoteles.Add(hotel);
                        i = 0;
                        Console.WriteLine("Si desea ver el listado de hoteles pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                for (var j = 0; j < listaHoteles.Count; j++)
                                {
                                    Console.WriteLine(listaHoteles[j].Nombre);
                                }
                                break;
                        }
                        break;
                    case "d":
                        Factur factura = new Factur();
                        Console.WriteLine("Comenzemos a ingresar facturas");
                        Console.WriteLine("Escriba el codigo de la factura");
                        string codigo = Console.ReadLine();
                        DateTime fecha = DateTime.Today;
                        
                        for (var m = 0; m < listaClientes.Count; m++)
                        {
                            Console.WriteLine($"{m + 1}: {listaClientes[m].Nombre}");
                        }
                        Console.WriteLine("Escriba el indice del cliente a ingresar");
                        string clientf = Console.ReadLine();
                        var clientf1 = int.Parse(clientf);
                        //hotel.Clientes = listaClientes[client1];
                        factura.Codigo = codigo;
                        factura.Fecha = fecha;
                        listaFacturas.Add(factura);
                        i = 0;
                        Console.WriteLine("Si desea ver el listado de hoteles pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                for (var j = 0; j < listaHoteles.Count; j++)
                                {
                                    Console.WriteLine(listaHoteles[j].Nombre);
                                }
                                break;
                        }
                        break;
                    case "x":
                        i = 1;
                        break;
                }              
            }
            
        }

    }
}
