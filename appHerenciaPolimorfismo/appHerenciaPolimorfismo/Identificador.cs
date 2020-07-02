using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace appHerenciaPolimorfismo
{
    class Identificador
    {
        Random generarId = new Random();
        public int Id { get; set; }
        public Identificador()
        {
            Id = generarId.Next();
        }

        public int generarRandom()
        {
            return Id;
        }
    }
}
