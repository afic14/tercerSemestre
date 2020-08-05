using Factura.Interface;
using System;
using System.Collections.Generic;

namespace facturaHotelActualizada
{
    public sealed class Factur : GeneradorId
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public ICliente Clientes { get; set; } 
        public IRecepcionista Recepcionista { get; set; } 
        public Hotel Hotel { get; set; }
        public List<Habitacion> Habitacion { get; set; } = new List<Habitacion>();
        public Factur()
        {

        }
        public Factur(string codigo, DateTime fecha)
        {
            Codigo = codigo;
            Fecha = fecha;
        }
        public ICliente AgregarCliente(ICliente cliente)
        {
            Clientes = cliente;
            return cliente;
        }
        public IRecepcionista AgregarRecepcionista(IRecepcionista recepcionista)
        {
            Recepcionista = recepcionista;
            return recepcionista;
        }
        public Habitacion AgregarHabitacion(Habitacion habitacion)
        {
            Habitacion.Add(habitacion);
            return habitacion;
        }
    }
}