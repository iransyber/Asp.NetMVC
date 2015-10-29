using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using SystemDevelopment.Entidades.Data1;
using CodeFirstStoreFunctions;

namespace SystemDevelopment.Contexto
{
    public class DBcontexto : DbContext
    {
        public DBcontexto(string stringConexao)
            : base(stringConexao)
        {
            //Database.SetInitializer(new MyContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new FunctionsConvention<DBcontexto>("dbo"));
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}