using System;
using System.Collections.Generic;
using System.Text;

namespace programaPorConsola
{
    class Habitacion
    {
        public string Id { get; set; }
        public string Color { get; set; }
        public string Numero { get; set; }
        public string Precio { get; set; }
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
        public string Pintar(string color)
        {
            return $"La habitación {Numero} fue pintada de color {color}";
        }
    }
}
