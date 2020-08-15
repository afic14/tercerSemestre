using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Factura.Interface;

namespace Factura.Entidades
{
    public class Recepcionista : Persona, IPersona, IRecepcionista
    {
        [Key]
        public int RecepcionistaId { get; set; }
        public string Sueldo { get; set; }
        public List<Factur> Factura { get; set; } = new List<Factur>();
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
        public override string Saludar()
        {
            return "Sea bienvenido"; 
        }

        public string Agregar()
        {
            return "Recepcionista agregado";
        }

        public string Eliminar()
        {
            return "Recepcionista eliminado";
        }

        public string Consultar()
        {
            return "Recepcionistas";
        }

        public string Cobrar(int precio)
        {
            return $"El precio de la habitacion es{precio}";
        }

        public string RecibirSalario()
        {
            return "Jefe, ya es hora de la quincena";
        }

        public string MarcarLLegada(DateTime hora)
        {
            return $"Llegué a las {hora}";
        }

        public string MarcarSalida(DateTime hora)
        {
            return $"Salí a las {hora}";
        }
    }
}
