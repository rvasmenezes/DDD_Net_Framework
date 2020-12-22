using DDD.Domain.Entidades;
using DDD.Domain.Interfaces.Repositories;
using System.Linq;

namespace DDD.Infra.Data.Repositories
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public Usuario LogarUsuario(string email, string senha)
        {
            var usuario = _contexto.Usuarios.Where(u => u.Email == email).FirstOrDefault();
            if (usuario == null)
                return null;

            return usuario;
        }

        public Usuario RecuperarUsuarioPorEmail(string email)
        {
            var usuario = _contexto.Usuarios.Where(u => u.Email == email).FirstOrDefault();
            return usuario;
        }
    }
}
