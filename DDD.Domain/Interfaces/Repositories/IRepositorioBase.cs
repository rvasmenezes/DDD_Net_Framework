using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioBase<TEntidade> where TEntidade : class
    {
        IList<TEntidade> RecuperarTodos();
        TEntidade RecuperarPorId(int Id);
        void Inserir(TEntidade obj);
        void Alterar(TEntidade obj);
        void Remover(TEntidade obj);
        void Remover(int Id);
    }
}
