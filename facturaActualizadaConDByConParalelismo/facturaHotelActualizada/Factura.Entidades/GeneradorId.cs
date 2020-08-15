using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Factura.Entidades
{
    public static class GeneradorId : Object
    {
        static int Generar(int id)
        {
            return id = new Random().Next();
        }
    }
}
