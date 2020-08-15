using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Interface
{
    public interface IRecepcionista
    {
        string Cobrar(int cobrar);
        string RecibirSalario();
        string MarcarLLegada(DateTime hora);
        string MarcarSalida(DateTime hora);
    }
}
