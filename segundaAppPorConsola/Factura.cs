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
        public string Crear()
        {
            return $"Se ha creado una nueva factura a nombre de {cliente.Nombre}, por el recepcionista {recepcionista.Nombre} en la habitacion {cuarto.Numero}";
        }
        public string Eliminar()
        {
            return "Se ha eliminado la factura";
        }

    }
}
