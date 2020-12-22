using DDD.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioPefilUsuario : IRepositorioBase<PerfilUsuario>
    {
        List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario);
    }
}
