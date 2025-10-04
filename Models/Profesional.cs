namespace appTurnos.Models
{
    public class Profesional
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int ProfesionalId { get; set; }
        public Profesional Prof { get; set; } = null!;
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Confirmado, Cancelado

        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
