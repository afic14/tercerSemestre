using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotelActualizada
{
    public class Persona : GeneradorId
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Celular { get; set; }
        public virtual string Saludar()
        {
            return "Hola";
        }
        public string Agregar()
        {
            return "Persona agregada";//agregar funcionalidad cuando conecte una base de datos
        }
        public string Eliminar()
        {
            return "Persona eliminada";//agregar funcionalidad cuando conecte una base de datos
        }
        public string Consultar()
        {
            return "Personas";//agregar funcionalidad cuando conecte una base de datos
        }
        public Persona()
        {

        }
    }
}
