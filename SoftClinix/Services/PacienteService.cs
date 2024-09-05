using SoftClinix.Models;
using System.Threading.Tasks;
using SoftClinix.Data;
using Microsoft.EntityFrameworkCore;

namespace SoftClinix.Services
{
    public class PacienteService
    {
        private readonly ApplicationDbContext _context;
        public PacienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Paciente Paciente { get; set; } = new Paciente();

        public async Task AddPacienteAsync(Paciente paciente)
        {
            _context.RegistroPacientes.Add(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task<Paciente> GetPacienteByIdAsync(int id)
        {
            return await _context.RegistroPacientes.FindAsync(id);
        }
    }
}