namespace facturaHotel
{
    public class Habitación : Generador
    {
        public string Código { get; set; }
        public string Camas { get; set; }
        public string Precio { get; set; }
        public Factura Factura { get; set; }
        public Habitación()
        {

        }
        public Habitación(string codigo, string camas, string precio)
        {
            Código = codigo;
            Camas = camas;
            Precio = precio;
        }
        public Habitación agregarHabitación(string codigo, string camas, string precio)
        {
            var newHabitación = new Habitación(codigo, camas, precio);
            return newHabitación;
        }
    }
}