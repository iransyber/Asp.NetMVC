using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;

namespace SystemDevelopment.Contexto
{
    public class DBcontexto : DbContext
    {
        public DBcontexto(string stringConexao)
            : base(stringConexao)
        { 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}