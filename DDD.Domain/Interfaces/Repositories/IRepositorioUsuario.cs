using DDD.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioUsuario : IRepositorioBase<Usuario>
    {
        Usuario RecuperarUsuarioPorEmail(string email);
        Usuario LogarUsuario(string email, string senha);
    }
}
