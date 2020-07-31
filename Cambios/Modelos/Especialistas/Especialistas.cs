using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCAME.Models
{
    public class Especialistas
    {
        public int Id { get; set; }
        public string TituloEgresado { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Cedula { get; set; }
        public string CodigoSenecyt { get; set; }
        public string Telefono { get; set; }
        //[ForeignKey("Especialidades")]
        //public int IdEspecialidad { get; set; }
        //public Consultorio Consultorio { get; set; }
        //public Especialidades Especialidades { get; set; }
    }
}
