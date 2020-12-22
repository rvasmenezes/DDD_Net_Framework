using DDD.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Data.Initializer
{
    public class UserDataBaseInitializer
    {
        public static List<ModulosAcesso> GetModulosAcesso()
        {
            var modulos = new List<ModulosAcesso>
            {
                new ModulosAcesso
                {
                    IdModulo = 1,
                    InAtivo = true,
                    NomeMenuAcesso = "Administração",
                    NomeModulo = "Admin",
                    UrlMenu = "#",
                    DataCadastro = DateTime.Now
                },
                new ModulosAcesso
                {
                    IdModulo = 2,
                    InAtivo = true,
                    NomeMenuAcesso = "Cadastro",
                    NomeModulo = "Admin",
                    UrlMenu = "#",
                    DataCadastro = DateTime.Now,
                    IdMoculoPai = 1
                },
                new ModulosAcesso
                {
                    IdModulo = 3,
                    InAtivo = true,
                    NomeMenuAcesso = "Perfil de usuário",
                    NomeModulo = "Perfil de usuário",
                    UrlMenu = "#",
                    DataCadastro = DateTime.Now,
                    IdMoculoPai = 2
                }
            };

            return modulos;
        }

        public static List<PerfilUsuario> GetPerfisUsuario()
        {
            var perfisUsuario = new List<PerfilUsuario>
            {
                new PerfilUsuario
                {
                    IdPerfilUsuario = 1,
                    DataCadastro = DateTime.Now,
                    InAdminMaster = true,
                    InAtivo = true,
                    NomePerfil = "Administrador Master",
                    ModulosAcesso = GetModulosAcesso()
                }
            };

            return perfisUsuario;
        }
    }
}
