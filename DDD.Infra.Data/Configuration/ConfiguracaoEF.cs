using DDD.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace DDD.Infra.Data.Configuration
{
    public class ModulosAcessoMap : EntityTypeConfiguration<ModulosAcesso>
    {

        public ModulosAcessoMap()
        {
            this.HasKey(p => p.IdModulo);

            this.Property(p => p.NomeModulo).IsRequired().HasMaxLength(200);
            this.Property(p => p.NomeMenuAcesso).IsRequired().HasMaxLength(200);
            this.Property(p => p.UrlMenu).IsRequired().HasMaxLength(300);
            this.Property(p => p.NomeModulo).IsRequired().HasMaxLength(200);

            this.ToTable("ModulosAcesso", "dbo");

            this.HasMany(p => p.PerfisUsuario)
                .WithMany(p => p.ModulosAcesso)
                .Map(n =>
                        {
                            n.ToTable("PerfilModulos", "dbo");
                            n.MapLeftKey("IdModulo");
                            n.MapRightKey("IdPerfilUsuario");
                        }                        
                ); 
        }
        
    }

    public class PerfilUsuarioMap : EntityTypeConfiguration<PerfilUsuario>
    {

        public PerfilUsuarioMap()
        {
            this.HasKey(p => p.IdPerfilUsuario);
            this.Property(p => p.NomePerfil).IsRequired().HasMaxLength(200);
            this.Property(p => p.DataCadastro).HasColumnType("datetime2");
            this.ToTable("PerfilUsuario", "dbo");
        }

    }

    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {

        public UsuarioMap()
        {
            this.HasKey(p => p.IdUsuario);
            this.Property(p => p.Nome).IsRequired().HasMaxLength(200);
            this.Property(p => p.Email).IsRequired().HasMaxLength(200)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName, 
                    new IndexAnnotation(
                        new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true}
                        )
                );

            this.Property(p => p.Senha).IsRequired().HasMaxLength(1024);
            this.Property(p => p.DataCadastro).HasColumnType("datetime2");

            this.HasRequired(p => p.PerfisUsuario)
                .WithMany(p => p.Usuarios).HasForeignKey(f => f.IdPerfilUsuario);

            this.ToTable("Usuario", "dbo");
        }

    }
}
