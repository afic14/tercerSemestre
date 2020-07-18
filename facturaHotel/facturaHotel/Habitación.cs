namespace facturaHotel
{
    public class Habitación : Generador
    {
        public string Código { get; set; }
        public int Camas { get; set; }
        public string Precio { get; set; }
        public Factura Factura { get; set; }
    }
}