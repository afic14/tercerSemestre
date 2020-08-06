using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Entidades
{
    public class ClienteHotel
    {
        public int ClienteId { get; set; }
        public Cliente Clientes { get; set; }
        public int HotelId { get; set; }
        public Hotel Hoteles { get; set; }
    }
}
