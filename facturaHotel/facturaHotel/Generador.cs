using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace facturaHotel
{
    public abstract class Generador : Object
    {
        private int Id;
        public int generar()
        {
            return this.Id = new Random().Next();
        }
    }
}
