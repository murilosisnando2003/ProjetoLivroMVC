using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto01.Models;
using Projeto01.Contexts;
using System.Data.Entity;

namespace Projeto01.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }

        public DbSet<Fabricante> Fabricantes { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        //public DbSet<Categoria> Categorias { get; set; }


    }
}