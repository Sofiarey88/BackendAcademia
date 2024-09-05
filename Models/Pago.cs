namespace AcademiaBaile.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string? MetodoPago { get; set; }
    }
}
