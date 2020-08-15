using System.Collections.Generic;

namespace Factura.Entidades
{
    public class Material 
    {
        public int MaterialId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Material()
        {

        }
        public Material(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public string Agregar()
        {
            return "Material agregado";
        }
        public string Eliminar()
        {
            return "Material eliminado";
        }
        public string Consultar()
        {
            return "Materiales";
        }
    }
}