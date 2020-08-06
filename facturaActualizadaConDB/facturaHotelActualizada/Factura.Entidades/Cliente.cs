using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Factura.Interface;

namespace Factura.Entidades
{
    public class Cliente : Persona, IPersona, ICliente
    {
        [Key]
        public int ClienteId { get; set; }
        public List<Factur> Factura { get; set; }
        public List<ClienteHotel> Hoteles { get; set; }
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

        public string Agregar()
        {
            return "Cliente agregado";
        }

        public string Eliminar()
        {
            return "Cliente eliminado";
        }

        public string Consultar()
        {
            return "Clientes";
        }

        public string Pagar()
        {
            return "Tome aquí está el dinero de la habitación";
        }

        public string SolicitarAtencion()
        {
            return "Buenas noches, me puede traer una aguita de Jamaica";
        }

        public string Retirarse()
        {
            return "Hasta la próxima";
        }
    }
}
