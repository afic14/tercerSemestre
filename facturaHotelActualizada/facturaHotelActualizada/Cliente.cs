using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotelActualizada
{
    class Cliente : Persona
    {
        public Factura Factura { get; set; }
        public Cliente()
        {
            
        }
        public Cliente(string cedula, string nombre, string apellido, string celular)
        {
            Identificacion = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
        }
    }
}
