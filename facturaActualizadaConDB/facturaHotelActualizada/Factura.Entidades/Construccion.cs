using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Factura.Entidades
{
    public abstract class Construccion 
    {
        public string Tipo { get; set; }
        public int Plantas { get; set; }
        public List<Material> Materiales { get; set; } = new List<Material>();
        public string Altura { get; set; }
        public Material AgregarMaterial(Material material)
        {
            Materiales.Add(material);
            return material;
        }
        public string Pintar()
        {
            return "Estoy pintando la construccion";
        }
       
    }
}
