namespace SoftClinix.Pages.ModuloAdmin
{
    public class UserService
    {
        // Clase User dentro del servicio
        public class Usuario
        {
            public string NombreUsuario { get; set; }
            public string Contrasena { get; set; }
            public DateTime FechaCreacion { get; set; }
        }

        private List<Usuario> usuarios = new List<Usuario>();

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        public void AgregarUsuario(string nombreUsuario, string contrasena)
        {
            if (!usuarios.Any(u => u.NombreUsuario == nombreUsuario))
            {
                usuarios.Add(new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    Contrasena = contrasena,
                    FechaCreacion = DateTime.Now
                });
            }
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            var usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
        }

        public void EditarUsuario(string nombreUsuario, string nuevaContrasena)
        {
            var usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            if (usuario != null)
            {
                usuario.Contrasena = nuevaContrasena;
            }
        }
    }
}
