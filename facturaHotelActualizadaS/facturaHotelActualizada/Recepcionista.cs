using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotelActualizada
{
    public class Recepcionista : Persona
    {
        public string Sueldo { get; set; }
        public Factura Factura { get; set; }
        public Recepcionista()
        {

        }
        public Recepcionista(string cedula, string nombre, string apellido, string celular, string sueldo)
        {
            Identificacion = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            Sueldo = sueldo;
        }
    }
}
