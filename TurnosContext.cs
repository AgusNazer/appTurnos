using appTurnos.Models;
using Microsoft.EntityFrameworkCore;

namespace appTurnos.Data  
{
    public class TurnosContext : DbContext
    {
        //public class DbContext
        //{

        //}

        public TurnosContext(DbContextOptions<TurnosContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profesional> profesionals { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
