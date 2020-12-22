using CommonServiceLocator;
using DDD.Domain.Interfaces.Infraestrutura;
using DDD.Infra.Data.Context;

namespace DDD.Infra.Data.Configuration
{
    public class UnidadeDeTrabalhoEF : IUnidadeDeTrabalho
    {
        private ContextoBanco _contexto;

        public void Iniciar()
        {
            var gerenciador = ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>() as GerenciadorDeRepositorio;

            _contexto = gerenciador.Contexto;
        }

        public void Persistir()
        {
            _contexto.SaveChanges();
        }
    }
}
