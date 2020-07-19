using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotel
{
    public class Cliente : Persona
    {
        public string Celular { get; set; }
        public Factura Factura { get; set; }
        public Cliente()
        {

        }
        public Cliente(string cedula, string nombre, string apellido, string celular)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            
        }
        public Cliente AgregarPersona(string cedula, string nombre, string apellido, string celular)
        {
            var nuevoCliente = new Cliente(cedula, nombre, apellido, celular);
            return nuevoCliente;
        }
    }
}
