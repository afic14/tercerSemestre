using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCAME.Models
{
    public class Especialidades
    {
        public int Id { get; set; }
        public string NombreEspecialidad { get; set; }
        //[ForeignKey("Especialistas")]
        //public int IdEspecialista { get; set; }
        //public Especialistas Especialistas { get; set; }
    }
}
