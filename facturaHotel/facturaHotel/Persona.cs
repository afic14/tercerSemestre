using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotel
{
    public class Persona : Generador
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona(string cedula, string nombre, string apellido)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public Persona()
        {

        }
        public Persona AgregarPersona(Persona persona)
        {
            if (persona != null)
                return persona;
            else
            return null;
        }
        private string ConsultarPersonas()
        {
            return "Inserte personas";
        }
        private string EliminarPersona()
        {
            return "Persona eliminada";
        }
        private string ModificarPersona()
        {
            return "Persona modificada";
        }
    }
}
