using System;
using System.Collections.Generic;
using System.Text;

namespace programaPorConsola
{
    class Recepcionista
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sueldo { get; set; }
        public string Agregar()
        {
            return $"Se agregó a {Nombre} como un/a nuevo/a trabajador/a";
        }
        public string Rentar(string habitacion, string cliente)
        {
            return $"{Nombre} rentó la habitación {habitacion} a {cliente}";
        }
        public string Despedir()
        {
            return $"{Nombre} fue despedido";
        }
        public string Pagar()
        {
            return $"{Nombre} recibió el pago de su sueldo";
        }
    }
}
