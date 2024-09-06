using Microsoft.EntityFrameworkCore;
using SoftClinix.Models;


namespace SoftClinix.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Paciente> RegistroPacientes { get; set; }
        public DbSet<Municipio> Municipios { get; set; } // Añadir este DbSet
    }
}