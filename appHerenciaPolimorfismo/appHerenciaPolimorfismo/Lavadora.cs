using System;
using System.Collections.Generic;
using System.Text;

namespace appHerenciaPolimorfismo 
{
    class Lavadora : Electrodomestico
    {
        public string Capacidad { get; set; }
        public string Color { get; set; }
        public Lavadora()
        {

        }
        public string lavar()
        {
            return $"Tu lavadora {Marca} está lavando";
        }
    }
}
