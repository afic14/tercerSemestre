using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Interface
{
    public interface ICliente
    {
        string Pagar();
        string SolicitarAtencion();
        string Retirarse();
    }
}
