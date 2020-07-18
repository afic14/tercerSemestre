using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotel
{
    public class Cliente : Persona
    {
        public string Celular { get; set; }
        public Factura Factura { get; set; }
        public Persona AgregarPersona(string cedula, string nombre, string apellido)
        {
            var nuevoCliente = new Persona(cedula, nombre, apellido);
            return nuevoCliente;
        }

    }
}
