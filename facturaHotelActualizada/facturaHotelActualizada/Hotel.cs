﻿using System;
using System.Collections.Generic;
using System.Text;

namespace facturaHotelActualizada
{
    class Hotel : Construccion
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Direccion { get; set; }
        public List<Persona> Clientes { get; set; } = new List<Persona>();
        public List<Persona> Personal { get; set; } = new List<Persona>();
        public Hotel()
        {

        }
        public Hotel(string nombre, string color, string direccion)
        {
            Nombre = nombre;
            Color = color;
            Direccion = direccion;
        }
        public string Pintar(string color)
        {
            return $"Estoy pintando el hotel {this.Nombre} de color {color}";
        }
        public static string Barrer()
        {
            return "estoy barriendo";
        }
        public Persona AgregarCliente(Persona cliente)
        {
            Clientes.Add(cliente);
            return cliente;
        }
        public Persona ContratarPersonal(Persona empleado)
        {
            Personal.Add(empleado);
            return empleado;
        }
    }
}
