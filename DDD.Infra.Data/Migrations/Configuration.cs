namespace DDD.Infra.Data.Migrations
{
    using DDD.Infra.Data.Initializer;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ContextoBanco>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ContextoBanco context)
        {
            if(context.PerfilUsuario.Where(x => x.NomePerfil == "Administrador Master").Count() == 0)
                UserDataBaseInitializer.GetPerfisUsuario().ForEach(c => context.PerfilUsuario.Add(c));

            foreach (var file in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug", ""), "Sql\\Seed"), "*.sql"))
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(file), new object[0]);
            }

            foreach (var file in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug", ""), "Sql\\StoredProcs"), "*.sql"))
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(file), new object[0]);
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
