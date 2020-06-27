using System;
using System.Collections.Generic;
using System.Text;

namespace programaPorConsola
{
    class Habitacion
    {
        public int Id { get; set; }
        public string Camas { get; set; }
        public string Numero { get; set; }
        public string Precio { get; set; }
        public Factura factura { get; set; }
        public string Agregar()
        {
            return $"Se agregó la habitación {Numero}";
        }
        public string Rentar(string persona)
        {
            return $"La habitación {Numero} fue rentada por {persona}";
        }
        public string Eliminar()
        {
            return "Eliminado";
        }
        public string Limpiar()
        {
            return "Se procederá a limpiar la habitación";
        }
    }
}
