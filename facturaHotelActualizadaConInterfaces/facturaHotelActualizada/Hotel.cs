using System;
using System.Collections.Generic;
using System.Text;
using Factura.Interface;

namespace facturaHotelActualizada
{
    public class Hotel : Construccion, IConstruccion
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Direccion { get; set; }
        public List<Persona> Clientes { get; set; } = new List<Persona>();
        public List<Persona> Personal { get; set; } = new List<Persona>();
        public List<Factur> Facturas { get; set; } = new List<Factur>();
        public Hotel()
        {

        }
        public Hotel(string nombre, string color, string direccion)
        {
            Nombre = nombre;
            Color = color;
            Direccion = direccion;
        }
        public string Pintar(string color)
        {
            base.Pintar();
            return $"Estoy pintando el hotel {this.Nombre} de color {color}";
        }
        public static string Barrer()
        {
            return "estoy barriendo";
        }
        public Persona AgregarCliente(Persona cliente)
        {
            Clientes.Add(cliente);
            return cliente;
        }
        public Persona ContratarPersonal(Persona empleado)
        {
            Personal.Add(empleado);
            return empleado;
        }

        public string Agregar()
        {
            return "Hotel agregado";
        }

        public string Eliminar()
        {
            return "Hotel eleminado";
        }

        public string Consultar()
        {
            return "Hoteles";
        }
    }
}
