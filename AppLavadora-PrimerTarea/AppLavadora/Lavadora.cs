using System;
using System.Collections.Generic;
using System.Text;

namespace AppLavadora
{
    class Lavadora
    {
        public string Marca;
        public string Modelo;
        public string Capacidad;
        public string Color;
        public string Encender()
        {
            return "Estoy encendiendo";
        }
        public string Apagar()
        {
            return "Me estoy apagando";
        }
        public string Lavar(string minutos)
        {
            return $"Estaré lavando durante {minutos} minutos";
        }
        public string Secar(string minutos)
        {
            return $"Estaré secando durante {minutos} minutos";
        }
        public Lavadora()
        {

        }
        public Lavadora(string marca, string modelo, string capacidad, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            Color = color;
        }
    }
}
