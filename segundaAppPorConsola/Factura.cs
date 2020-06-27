using System;
using System.Collections.Generic;
using System.Text;

namespace programaPorConsola
{
    class Factura
    {
        public string RUC { get; set; }
        public string Numero { get; set; }
        public string Fecha { get; set; }
        public string Detalle { get; set; }
        public Habitacion cuarto { get; set; }
        public Recepcionista recepcionista { get; set; }
        public Cliente cliente { get; set; }
        public string Crear(string nombreCliente, string nombreRecepcionista, string habitacion)
        {
            return "Se ha creado una nueva factura";
        }
        public string Eliminar()
        {
            return "Se ha eliminado la factura";
        }

    }
}
