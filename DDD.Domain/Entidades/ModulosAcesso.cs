using System;
using System.Collections.Generic;

namespace DDD.Domain.Entidades
{
    public partial class ModulosAcesso
    {
        public ModulosAcesso()
        {
            this.PerfisUsuario = new List<PerfilUsuario>();
        }

        public int IdModulo { get; set; }
        public string NomeModulo { get; set; }
        public string NomeMenuAcesso { get; set; }
        public string UrlMenu { get; set; }
        public bool InAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdMoculoPai { get; set; }
        public virtual ModulosAcesso ModulosAcessos { get; set; }
        public virtual ICollection<PerfilUsuario> PerfisUsuario { get; set; }
    }
}