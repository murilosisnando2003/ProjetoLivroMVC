using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Modelo.Cadastros;

namespace Persistencia.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }

        public DbSet<Fabricante> Fabricantes { get; set; }

        public DbSet<Modelo.Cadastros.Cidade> Cidades { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public System.Data.Entity.DbSet<Modelo.Tabelas.Categoria> Categorias { get; set; }

        //public DbSet<Categoria> Categorias { get; set; }


    }
}