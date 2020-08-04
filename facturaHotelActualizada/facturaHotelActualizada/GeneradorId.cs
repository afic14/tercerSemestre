using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace facturaHotelActualizada
{
    public abstract class GeneradorId : Object
    {
        protected int Id { get; set; } 
        private int Generar()
        {
            return Id = new Random().Next();
        }
        public GeneradorId()
        {
            Generar();
        }
    }
}
