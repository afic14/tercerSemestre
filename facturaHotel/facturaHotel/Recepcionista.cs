namespace facturaHotel
{
    public class Recepcionista : Persona
    {
        public string Celular { get; set; }
        public string Sueldo { get; set; }
        public Factura Factura { get; set; }
        public Recepcionista()
        {
           
        }
        public Recepcionista(string cedula, string nombre, string apellido, string celular, string sueldo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            Sueldo = sueldo;
        }
        public Persona AgregarPersonal(string cedula, string nombre, string apellido)
        {
            var nuevoTrabajador = new Persona(cedula, nombre, apellido);
            return nuevoTrabajador;
        }
        public Recepcionista AgregarPersonal(string cedula, string nombre, string apellido, string celular, string sueldo)
        {
            var nuevoTrabajador = new Recepcionista(cedula, nombre, apellido, celular, sueldo);
            return nuevoTrabajador;
        }
    }
}