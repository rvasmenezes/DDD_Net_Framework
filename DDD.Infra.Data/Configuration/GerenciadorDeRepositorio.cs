using DDD.Domain.Interfaces.Infraestrutura;
using DDD.Infra.Data.Context;
using System.Web;

namespace DDD.Infra.Data.Configuration
{
    public class GerenciadorDeRepositorio : IGerenciadorDeRepositorio
    {
        public const string ContextoHttp = "ContextoHttp";

        public ContextoBanco Contexto
        {
            get
            {
                if (HttpContext.Current.Items[ContextoHttp] == null)
                    HttpContext.Current.Items[ContextoHttp] = new ContextoBanco();
                return HttpContext.Current.Items[ContextoHttp] as ContextoBanco;
            }
        }

        public void Finalizar()
        {
            if (HttpContext.Current.Items[ContextoHttp] != null)
                (HttpContext.Current.Items[ContextoHttp] as ContextoBanco).Dispose();
        }
    }
}
