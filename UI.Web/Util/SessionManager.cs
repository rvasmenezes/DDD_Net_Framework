using DDD.Domain.Entidades;
using System.Web;

namespace UI.Web.Util
{
    public class SessionManager
    {

        public static Usuario UsuarioLogado
        {
            set
            {
                HttpContext.Current.Session.Add("UsuarioLogado", value);
            }
            get
            {
                return (Usuario)HttpContext.Current.Session["UsuarioLogado"];
            }
        }

        public static bool IsAuthenticated
        {
            get
            {
                return ((Usuario)HttpContext.Current.Session["UsuarioLogado"]) != null;
            }
        }

    }
}