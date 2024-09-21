namespace SoftClinix.Models
{
    public class RegistroPaciente
    {
        public int Id { get; set; } // Asegúrate de tener el campo Id como clave primaria
        public string SecuenciaHO { get; set; }
        public string NoHistoria { get; set; }
        public DateTime FechaHoraIngreso { get; set; }
        public string CodigoBarras { get; set; }
        public string Procedencia { get; set; }
        public string Presupuesto { get; set; }
        public string Paciente { get; set; }
        public string Habitacion { get; set; }
        public string EstanciaAprox { get; set; }
        public string HoraCorte { get; set; }
        public string PaqueteAtencion { get; set; }
        public string Estado { get; set; }
        public string NombreResponsable { get; set; }
        public string DireccionResponsable { get; set; }
        public string DocumentoResponsable { get; set; }
        public string TelefonoResponsable { get; set; }
        public string Aval1 { get; set; }
        public string Aval2 { get; set; }
        public string Aval3 { get; set; }
        public string Plan { get; set; }
        public string AberturaMaxima { get; set; }
        public decimal Coaseguro { get; set; }
        public decimal Deducible { get; set; }
        public string DocumentoAsociado { get; set; }
        public string Siniestro { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string PlacaNo { get; set; }
        public string Observaciones { get; set; }
    }
}