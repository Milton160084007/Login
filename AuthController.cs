using Login.Models;
using System.Collections.Generic;

namespace Login.Controllers
{
    public class AuthController
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public int IntentosFallidos { get; private set; }

        public AuthController()
        {
            // Usuario de prueba
            usuarios.Add(new Usuario
            {
                NombreUsuario = "admin",
                Contrasena = "123"
            });
        }

        public bool Login(string usuario, string contrasena)
        {
            foreach (var user in usuarios)
            {
                if (user.NombreUsuario == usuario && user.Contrasena == contrasena)
                {
                    return true;
                }
            }

            IntentosFallidos++;
            return false;
        }
    }
}