using CommonServiceLocator;
using DDD.Domain.Interfaces.Infraestrutura;
using DDD.Domain.Interfaces.Repositories;
using DDD.Infra.Data.Configuration;
using DDD.Infra.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DDD.Infra.Data.Repositories
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {

        protected readonly ContextoBanco _contexto;

        public RepositorioBase()
        {
            var gerenciador = (GerenciadorDeRepositorio)ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>();
            _contexto = gerenciador.Contexto;
        }

        public void Alterar(TEntidade obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
        }

        public void Inserir(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Add(obj);
        }

        public TEntidade RecuperarPorId(int Id)
        {
            return _contexto.Set<TEntidade>().Find(Id);
        }

        public IList<TEntidade> RecuperarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public void Remover(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Remove(obj);
        }

        public void Remover(int Id)
        {
            TEntidade obj = RecuperarPorId(Id);
            Remover(obj);
        }
    }
}
