using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Modelo.Cadastros;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Persistencia.Contexts
{
    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //    modelBuilder.Conventions.Remove<PluralizingTableNomeConvention>();
    //}

    public class EFContext : DbContext
    {
         


        public EFContext() : base("Asp_Net_MVC_CS")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public DbSet<Fabricante> Fabricantes { get; set; }

        //public DbSet<Modelo.Cadastros.Cidade> Cidades { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public System.Data.Entity.DbSet<Modelo.Tabelas.Categoria> Categorias { get; set; }

        //public DbSet<Categoria> Categorias { get; set; }


    }
}