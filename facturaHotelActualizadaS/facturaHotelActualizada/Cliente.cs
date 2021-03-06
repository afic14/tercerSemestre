﻿using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotelActualizada
{
    public class Cliente : Persona
    {
        public Factura Factura { get; set; }
        public Cliente()
        {
            
        }
        public Cliente(string cedula, string nombre, string apellido, string celular)
        {
            Identificacion = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
        }
        public override string Saludar()
        {
            return "Buenas tardes, me ayuda con una habitación";
        }
    }
}
