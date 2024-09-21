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
        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<RegistroPaciente> RegistroHospitalizacion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Paciente>().ToTable("registro_pacientes");
            modelBuilder.Entity<Municipio>().ToTable("municipios");
            modelBuilder.Entity<RegistroPaciente>().ToTable("registro_hospi");

            base.OnModelCreating(modelBuilder);
        }
    }
}