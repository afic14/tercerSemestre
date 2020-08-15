using Factura.Interface;
using System;
using System.Collections.Generic;
using Factura.Entidades;
using System.Threading.Tasks;

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
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            Console.WriteLine("Bienvenido");
            //Pd: No muestro las listas al principio de los submenus ya que es una app de prueba que no toma datos de una DB aun está conectada a una DB
            for (var i = 0; i<2; i++)
            {
                Console.WriteLine("Presione a para agregar clientes, b para agregar recepcionistas, c para agregar hoteles, d para agregar facturas, e para agregar habitaciones o x para salir");
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
                                /*for (var j = 0; j < listaClientes.Count; j++)
                                {
                                    Console.WriteLine(listaClientes[j].Nombre);
                                }*/
                                Parallel.ForEach(listaClientes, (listclientes) => {
                                    Console.WriteLine($"{listclientes.Nombre}");
                                });
                                break;
                        }
                        i = 0;
                        break;
                    case "b":
                        Recepcionista recepcionista = new Recepcionista();
                        Console.WriteLine("Comenzemos a ingresar recepcionistas");
                        Console.WriteLine("Escriba el nombre del recepcionista");
                        string nombrer = Console.ReadLine();
                        Console.WriteLine("Escriba el apellido del recepcionista");
                        string apellidor = Console.ReadLine();
                        Console.WriteLine("Escriba el numero de cedula del recepcionista");
                        string identificacionr = Console.ReadLine();
                        Console.WriteLine("Escriba el celular del recepcionista");
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
                                /*var time = System.Diagnostics.Stopwatch.StartNew();
                                for (var j = 0; j < listaRecepcionistas.Count; j++)
                                {
                                    Console.WriteLine(listaRecepcionistas[j].Nombre);
                                }
                                time.Stop();
                                var tt = time.ElapsedMilliseconds;
                                Console.WriteLine($"tiempo transcurrido en milisegundos: {tt}");*/
                                var watch = System.Diagnostics.Stopwatch.StartNew();
                                Parallel.ForEach(listaRecepcionistas, (listrecepcionistas) => {
                                    Console.WriteLine($"{listrecepcionistas.Nombre}");
                                });
                                watch.Stop();
                                var tiempo = watch.ElapsedMilliseconds;
                                Console.WriteLine($"tiempo transcurrido en milisegundos: {tiempo}");
                                //PD: El for es mas rapido que el parallel.foreach
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
                        /*for (var m = 0; m<listaClientes.Count; m++)
                        {
                            Console.WriteLine($"{m}: {listaClientes[m].Nombre}");
                        }*/
                        
                        for (int j=0; j<2; j++)
                        {
                            Console.WriteLine("Si desea agregar clientes presione a, si desea agregar recepcionistas presione b, si desea continuar presione x");
                            switch (Console.ReadLine())
                            {
                                case "a":
                                    int indice = 0;
                                    Parallel.ForEach(listaClientes, (list) =>
                                    {
                                        Console.WriteLine($"{indice} : {list.Nombre}");
                                        indice++;
                                    });
                                    Console.WriteLine("Escriba el indice del cliente a ingresar");
                                    string client = Console.ReadLine();
                                    var client1 = int.Parse(client);
                                    ClienteHotel.Clientes = listaClientes[client1];
                                    
                                    ClienteHotel.Hoteles = hotel;
                                    
                                    j = 0;
                                    break;
                                case "b":
                                    int indice1 = 0;
                                    Parallel.ForEach(listaRecepcionistas, (list) =>
                                    {
                                        Console.WriteLine($"{indice1} : {list.Nombre}");
                                        indice1++;
                                    });
                                    Console.WriteLine("Escriba el indice del recepcionista a ingresar");
                                    string recep2 = Console.ReadLine();
                                    var recep3 = int.Parse(recep2);
                                    hotel.Personal.Add(listaRecepcionistas[recep3]);
                                    j = 0;
                                    break;
                                case "x":
                                    j = 2;
                                    break;
                            }
                        }                                              
                        //hotel.Clientes = hotel.Clientes.Add(listaClientes[client1].);
                        hotel.Nombre = nombreh;
                        hotel.Color = color;
                        hotel.Direccion = direccion;
                        listaHoteles.Add(hotel);
                        i = 0;
                        Console.WriteLine("Si desea ver el listado de hoteles pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                /*for (var j = 0; j < listaHoteles.Count; j++)
                                {
                                    Console.WriteLine(listaHoteles[j].Nombre);
                                }
                                break;*/
                                Parallel.ForEach(listaHoteles, (list) =>
                                {
                                    Console.WriteLine(list.Nombre);
                                });
                                break;
                        }
                        break;
                    case "e":
                        Habitacion habitacion = new Habitacion();
                        Console.WriteLine("Vamos a agregar habitaciones");
                        Console.WriteLine("Ingrese el codigo habitaciones");
                        string codigoh = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de camas");
                        string camas = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio de la habitacion");
                        string precio = Console.ReadLine();
                        habitacion.Codigo = codigoh;
                        habitacion.Camas = camas;
                        habitacion.Precio = precio;
                        listaHabitaciones.Add(habitacion);
                        Console.WriteLine("Si desea ver el listado de habitaciones pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                Parallel.ForEach(listaHabitaciones, (list) =>
                                {
                                    Console.WriteLine(list.Codigo);
                                });
                                break;
                        }
                        i = 0;
                        break;
                    case "d":
                        Factur factura = new Factur();
                        Console.WriteLine("Comenzemos a ingresar facturas");
                        Console.WriteLine("Escriba el codigo de la factura");
                        string codigo = Console.ReadLine();
                        DateTime fecha = DateTime.Today;
                        Console.WriteLine("Este es el listado de clientes");
                        for (var m = 0; m < listaClientes.Count; m++)
                        {
                            Console.WriteLine($"{m}: {listaClientes[m].Nombre}");
                        }
                        Console.WriteLine("Escriba el indice del cliente a ingresar");
                        string client2 = Console.ReadLine();
                        var client3 = int.Parse(client2);
                        factura.Clientes = listaClientes[client3];
                        Console.WriteLine("Este es el listado de recepcionistas");
                        for (var m = 0; m < listaRecepcionistas.Count; m++)
                        {
                            Console.WriteLine($"{m}: {listaRecepcionistas[m].Nombre}");
                        }
                        Console.WriteLine("Escriba el indice del recepcionista a ingresar");
                        string recep = Console.ReadLine();
                        var recep1 = int.Parse(recep);
                        factura.Recepcionista = listaRecepcionistas[recep1];
                        Console.WriteLine("Este es el listado de hoteles");
                        for (var j = 0; j < listaHoteles.Count; j++)
                        {
                            Console.WriteLine($"{j}: {listaHoteles[j].Nombre}");
                        }
                        Console.WriteLine("Escriba el indice del hotel a ingresar");
                        string hotel2 = Console.ReadLine();
                        var hotel3 = int.Parse(hotel2);
                        factura.Hotel = listaHoteles[hotel3];
                        Console.WriteLine("Este es el listado de habitaciones");
                        for (var l = 0; l<listaHabitaciones.Count; l++)
                        {
                            Console.WriteLine($"{l}: {listaHabitaciones[l].Codigo}");
                        }
                        Console.WriteLine("Escriba el indice de la habitación a ingresar");
                        string hab = Console.ReadLine();
                        var hab1 = int.Parse(hab);
                        HabitacionFactura.Factura = factura;
                        HabitacionFactura.Habitaciones = listaHabitaciones[hab1];
                        for (var p = 0; p<2; p++)
                        {
                            Console.WriteLine("Si desea agregar mas habitaciones presione a caso contrario presione x");
                            switch (Console.ReadLine())
                            {
                                case "a":
                                    Parallel.ForEach(listaHabitaciones, (listhabitaciones) => {
                                        Console.WriteLine($"{listhabitaciones.Codigo}");
                                    });
                                    Console.WriteLine("Escriba el indice de la habitación a ingresar");
                                    string hab3 = Console.ReadLine();
                                    var hab4 = int.Parse(hab3);
                                    HabitacionFactura.Factura = factura;
                                    HabitacionFactura.Habitaciones = listaHabitaciones[hab4];
                                    p = 0;
                                    break;
                                case "x":
                                    p = 2;
                                    break;
                            }
                        }
                        //ClienteHotel.ClienteId = listaClientes[client3].ClienteId;
                        factura.Codigo = codigo;
                        factura.Fecha = fecha;
                        listaFacturas.Add(factura);
                        i = 0;
                        Console.WriteLine("Si desea ver el listado de facturas pulse a, caso contrario pulse otra tecla");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                Parallel.ForEach(listaFacturas, (listfacturas) => {
                                    Console.WriteLine($"{listfacturas.Codigo}");
                                });
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
