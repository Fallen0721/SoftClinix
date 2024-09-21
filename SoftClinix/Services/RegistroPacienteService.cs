using Microsoft.EntityFrameworkCore;
using SoftClinix.Data;
using SoftClinix.Models;

namespace SoftClinix.Services
{
    public class RegistroPacienteService
    {
        private readonly ApplicationDbContext _context;

        public RegistroPaciente CurrentRegistro { get; set; }

        public RegistroPacienteService(ApplicationDbContext context)
        {
            _context = context;
            CurrentRegistro = new RegistroPaciente();
        }

        public void SetRegistro(RegistroPaciente registro)
        {
            CurrentRegistro = registro;
        }

        public async Task SaveRegistroAsync()
        {
            if (CurrentRegistro.Id == 0)
            {
                _context.RegistroHospitalizacion.Add(CurrentRegistro);
            }
            else
            {
                _context.RegistroHospitalizacion.Update(CurrentRegistro);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<RegistroPaciente> GetRegistroByIdAsync(int id)
        {
            return await _context.RegistroHospitalizacion.FindAsync(id);
        }
    }
}