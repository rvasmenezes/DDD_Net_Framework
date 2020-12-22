using DDD.Domain.Entidades;
using DDD.Domain.Interfaces.Domain;
using DDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace DDD.Domain.Services
{
    public class ServicoDeUsuarioDomain : IServicoDeUsuarioDomain
    {

        private readonly IRepositorioUsuario _repositorioUsuario;
        private readonly IRepositorioPefilUsuario _repositorioPefilUsuario;

        public ServicoDeUsuarioDomain(IRepositorioUsuario repositorioUsuario, IRepositorioPefilUsuario repositorioPefilUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
            _repositorioPefilUsuario = repositorioPefilUsuario;
        }

        public Usuario LogarUsuario(string email, string senha)
        {
            //Todas as regras de negocio ficam aqui.
            var usuarioRetorno = _repositorioUsuario.LogarUsuario(email, senha);
            return usuarioRetorno;
        }

        public Usuario RecuperaUsuarioPorEmail(string email)
        {
            var usuarioRetorno = _repositorioUsuario.RecuperarUsuarioPorEmail(email);
            return usuarioRetorno;
        }

        public List<Usuario> RecuperaUsuariosDoPerfil(int idUsuarioPerfil)
        {
            var usuariosRetorno = _repositorioPefilUsuario.RetornaUsuariosDoPerfil(idUsuarioPerfil);
            return usuariosRetorno;
        }
    }
}
