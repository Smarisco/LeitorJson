using Microsoft.EntityFrameworkCore;
using DesafioJson.Model;

namespace DesafioJson.Data
{
    public class UnidadeGestoraContext:DbContext
    {
        public DbSet<UnidadeGestora> UnidadeGestora { get; set; }
        public DbSet<UnidadeOrcamentaria> UnidadeOrcamentaria { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DesafioJson;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new UnidadeGestoraMapping());
            modelBuilder.ApplyConfiguration(new UnidadeOrcamentariaMapping());
            modelBuilder.ApplyConfiguration(new ContadoresMapping());
        }

    }
}
