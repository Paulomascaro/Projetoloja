using Projetoloja.backend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Projetoloja.backend.database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("MySqlConnection")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
