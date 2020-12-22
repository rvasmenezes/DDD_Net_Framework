using DDD.Domain.Entidades;
using DDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Data.Repositories
{
    public class RepositorioPerfilUsuario : RepositorioBase<PerfilUsuario>, IRepositorioPefilUsuario
    {
        public List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario)
        {
            var perfil = _contexto.PerfilUsuario.Where(x => x.IdPerfilUsuario == idPerfilUsuario).FirstOrDefault();
            return perfil.Usuarios.ToList();
        }
    }
}
