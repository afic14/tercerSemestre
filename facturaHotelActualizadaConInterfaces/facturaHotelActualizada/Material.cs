using System.Collections.Generic;

namespace facturaHotelActualizada
{
    public class Material : GeneradorId
    {
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