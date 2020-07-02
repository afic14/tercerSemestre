using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace appHerenciaPolimorfismo
{
    class Electrodomestico : Identificador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public Electrodomestico()
        {
           
        }
        public string encender(string tipoElectrodomestico)
        {
            return $"Su {tipoElectrodomestico} se está encendiendo";
        }
        public string apagar(string tipoElectrodomestico)
        {
            return $"Su {tipoElectrodomestico} se está apagando";
        }
    }
}
