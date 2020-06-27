using System;

namespace programaPorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string cedulaCliente;
            string nombreCliente;
            string apellidoCliente;
            string celularCliente;
            string cedulaRecepcionista;
            string nombreRecepcionista;
            string apellidoRecepcionista;
            string sueldoRecepcionista;
            int generador = new Random().Next();
            string camasHabitacion;
            string numeroHabitacion;
            string precioHabitacion;
            string RUCFactura;
            string numeroFactura;
            string fechaFactura;
            string detalleFactura;

            Console.WriteLine("Ingresa los datos del usario");
            Console.WriteLine("Ingresa la cedula");
            cedulaCliente = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido");
            apellidoCliente = Console.ReadLine();
            Console.WriteLine("Ingresa el celular");
            celularCliente = Console.ReadLine();

            Console.WriteLine("Ingresa los datos del recepcionista");
            Console.WriteLine("Ingresa la cedula");
            cedulaRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre");
            nombreRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido");
            apellidoRecepcionista = Console.ReadLine();
            Console.WriteLine("Ingresa el sueldo");
            sueldoRecepcionista = Console.ReadLine();

            Console.WriteLine("Ingresa los datos de la habitacion");
            Console.WriteLine("Ingresa el numero de camas");
            camasHabitacion = Console.ReadLine();
            Console.WriteLine("Ingresa el numero");
            numeroHabitacion = Console.ReadLine();
            Console.WriteLine("Ingresa el precio");
            precioHabitacion = Console.ReadLine();

            Console.WriteLine("Ingresa los datos de la factura");
            Console.WriteLine("Ingresa el RUC del hotel");
            RUCFactura = Console.ReadLine();
            Console.WriteLine("Ingresa el numero");
            numeroFactura = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha");
            fechaFactura = Console.ReadLine();
            Console.WriteLine("Ingresa el detalle");
            detalleFactura = Console.ReadLine();

            Cliente cliente = new Cliente
            {
                Cedula = cedulaCliente,
                Nombre = nombreCliente,
                Apellido = apellidoCliente,
                Celular = cedulaCliente
            };

            Recepcionista recepcionista = new Recepcionista
            {
                Cedula = cedulaRecepcionista,
                Nombre = nombreRecepcionista,
                Apellido = apellidoRecepcionista,
                Sueldo = sueldoRecepcionista
            };

            Habitacion habitacion = new Habitacion
            {
                Id = generador,
                Numero = numeroHabitacion,
                Camas = camasHabitacion,
                Precio = precioHabitacion
            };

            Factura factura = new Factura
            {
                RUC = RUCFactura,
                Numero = numeroFactura,
                Fecha = fechaFactura,
                Detalle = detalleFactura,
                cliente = cliente,
                recepcionista = recepcionista,
                cuarto = habitacion
            };

            cliente.factura = factura;

            recepcionista.factura = factura;

            habitacion.factura = factura;

            Console.WriteLine(factura.Crear());
        }
    }
}
