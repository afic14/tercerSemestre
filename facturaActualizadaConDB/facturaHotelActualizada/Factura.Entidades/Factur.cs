using Factura.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factura.Entidades
{
    public sealed class Factur 
    {
        [Key]
        public int FacturaId { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Clientes { get; set; } 
        public Recepcionista Recepcionista { get; set; } 
        public Hotel Hotel { get; set; }
        public List<HabitacionFactura> Habitacion { get; set; } = new List<HabitacionFactura>();
        public Factur()
        {

        }
        public Factur(string codigo, DateTime fecha)
        {
            Codigo = codigo;
            Fecha = fecha;
        }
        public Cliente AgregarCliente(Cliente cliente)
        {
            Clientes = cliente;
            return cliente;
        }
        public Recepcionista AgregarRecepcionista(Recepcionista recepcionista)
        {
            Recepcionista = recepcionista;
            return recepcionista;
        }
        public HabitacionFactura AgregarHabitacion(HabitacionFactura habitacion)
        {
            Habitacion.Add(habitacion);
            return habitacion;
        }
    }
}