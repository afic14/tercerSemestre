using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using System.Text;

namespace Factura.Entidades
{
    public class Habitacion
    {
        [Key]
        public int HabitacionId { get; set; }
        public string Codigo { get; set; }
        public string Camas { get; set; }//escribo de tipo string cuando deberia poner int porque cuando se ingresa un dato por la consola lo toma como string y no he podido transformarlo en int
        public string Precio { get; set; }
        public List<HabitacionFactura> Factura { get; set; } = new List<HabitacionFactura>();
        public Habitacion()
        {

        }
        public Habitacion(string codigo, string camas, string precio)
        {
            Codigo = codigo;
            Camas = camas;
            Precio = precio;
        }
        public string Agregar()
        {
            return "Habitación agregada";
        }
        public string Eliminar()
        {
            return "Habitación eliminada";
        }
        public HabitacionFactura AgregarFactura(HabitacionFactura factura)
        {
            Factura.Add(factura);
            return factura;
        }
    }
}
