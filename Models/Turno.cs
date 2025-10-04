namespace appTurnos.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int ProfesionalId { get; set; }
        public Profesional Profesional { get; set; } = null!;
        public string Estado { get; set; } = "Pendiente"; // Pendiente, confirmado, cancelado
    }
}
