using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Entidades
{
    public class HabitacionFactura
    {
        public int HabitacionId { get; set; }
        public Habitacion Habitaciones { get; set; }
        public int FacturaId { get; set; }
        public Factur Factura { get; set; }
    }
}
