using System;
using System.Collections.Generic;

namespace facturaHotelActualizada
{
    public class Factura : GeneradorId
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public List<Persona> Clientes { get; set; } = new List<Persona>();
        public List<Persona> Recepcionista { get; set; } = new List<Persona>();
        public List<Habitacion> Habitacion { get; set; } = new List<Habitacion>();
        public Factura()
        {

        }
        public Factura(string codigo, DateTime fecha)
        {
            Codigo = codigo;
            Fecha = fecha;
        }
        public Persona AgregarCliente(Persona cliente)
        {
            Clientes.Add(cliente);
            return cliente;
        }
        public Persona AgregarRecepcionista(Persona recepcionista)
        {
            Recepcionista.Add(recepcionista);
            return recepcionista;
        }
        public Habitacion AgregarHabitacion(Habitacion habitacion)
        {
            Habitacion.Add(habitacion);
            return habitacion;
        }
    }
}