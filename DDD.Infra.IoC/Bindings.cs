using CommonServiceLocator;
using DDD.Domain.Interfaces.Domain;
using DDD.Domain.Interfaces.Infraestrutura;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Services;
using DDD.Infra.Data.Configuration;
using DDD.Infra.Data.Repositories;
using SimpleInjector;

namespace DDD.Infra.IoC
{
    public class Bindings
    {

        public static void Start(Container container)
        {

            //Infra
            container.Register<IGerenciadorDeRepositorio, GerenciadorDeRepositorio>();
            container.Register<IUnidadeDeTrabalho, UnidadeDeTrabalhoEF>();
            container.Register(typeof(IRepositorioBase<>), typeof(RepositorioBase<>), Lifestyle.Scoped);
            container.Register(typeof(IRepositorioUsuario), typeof(RepositorioUsuario), Lifestyle.Scoped);
            container.Register(typeof(IRepositorioPefilUsuario), typeof(RepositorioPerfilUsuario), Lifestyle.Scoped);

            //Dominio
            container.Register(typeof(IServicoDeUsuarioDomain), typeof(ServicoDeUsuarioDomain), Lifestyle.Scoped);

            //ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
        }

    }
}
