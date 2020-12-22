using DDD.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.Domain
{
    public interface IServicoDeUsuarioDomain
    {
        Usuario LogarUsuario(string email, string senha);
        Usuario RecuperaUsuarioPorEmail(string email);
        List<Usuario> RecuperaUsuariosDoPerfil(int idUsuarioPerfil);
    }
}
