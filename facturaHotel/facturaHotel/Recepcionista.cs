namespace facturaHotel
{
    public class Recepcionista : Persona
    {
        public string Celular { get; set; }
        public float Sueldo { get; set; }
        public Factura Factura { get; set; }

    }
}