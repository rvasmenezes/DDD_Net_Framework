using System;
using System.Collections.Generic;

namespace DDD.Domain.Entidades
{
    public partial class PerfilUsuario
    {

        public PerfilUsuario()
        {
            this.Usuarios = new List<Usuario>();
            this.ModulosAcesso = new List<ModulosAcesso>();
        }

        public int IdPerfilUsuario { get; set; }
        public string NomePerfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool InAdminMaster { get; set; }
        public bool InAtivo { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<ModulosAcesso> ModulosAcesso { get; set; }

    }
}
