using System;
using System.Collections.Generic;
using System.Text;

namespace programaPorConsola
{
    class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public Factura factura { get; set; }
        public string Agregar()
        {
            return $"Se agregó a {Nombre}";
        }
        public string Rentar(string habitacion)
        {
            return $"El usuario {Nombre} rentó la habitación {habitacion}";
        }
        public string Eliminar()
        {
            return "Eliminado";
        }
        public string Pagar()
        {
            return $"El cliente {Nombre} ha pagado correctamente";
        }
    }
}
