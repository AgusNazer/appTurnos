using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace appTurnos.Data
{
    public class TurnosContextFactory : IDesignTimeDbContextFactory<TurnosContext>
    {
        public TurnosContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TurnosContext>();

           
            optionsBuilder.UseSqlServer("Server=DESKTOP-P3T5T4K\\SQLEXPRESS;Database=TurnosDB;Trusted_Connection=True;TrustServerCertificate=True");

            return new TurnosContext(optionsBuilder.Options);
        }
    }
}
