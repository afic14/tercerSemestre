using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Factura.Interface;

namespace Factura.Entidades
{
    public class Hotel : Construccion, IConstruccion
    {
        [Key]
        public int HotelId { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Direccion { get; set; }
        public List<ClienteHotel> Clientes { get; set; } = new List<ClienteHotel>();
        public List<Recepcionista> Personal { get; set; } = new List<Recepcionista>();
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
        public ClienteHotel AgregarCliente(ClienteHotel cliente)
        {
            Clientes.Add(cliente);
            return cliente;
        }
        public Recepcionista ContratarPersonal(Recepcionista empleado)
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
