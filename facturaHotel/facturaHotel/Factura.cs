using System;
using System.Runtime.InteropServices.ComTypes;

namespace facturaHotel
{
    public class Factura : Generador
    {
        public string Código { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Recepcionista Recepcionista { get; set; }
        public Habitación Habitación { get; set; }
        public Factura()
        {

        }
        public Factura(string codigo, DateTime fecha)
        {
            Código = codigo;
            Fecha = fecha;
        }
        public Factura CrearFactura(string codigo, DateTime fecha)
        {
            var newFactura = new Factura(codigo, fecha);
            return newFactura;
        }
        public string ConsultarFacturas()
        {
            return "Listado de facturas";
        }

    }
}