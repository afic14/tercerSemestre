using System;

namespace facturaHotel
{
    public class Factura : Generador
    {
        public string Código { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Recepcionista Recepcionista { get; set; }
        public Habitación Habitación { get; set; }
        public string CrearFactura()
        {
            return "Factura creada";
        }
        public string ConsultarFacturas()
        {
            return "Listado de facturas";
        }
    }
}