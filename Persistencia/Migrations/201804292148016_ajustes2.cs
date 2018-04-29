namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustes2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categorias", newName: "Categoria");
            RenameTable(name: "dbo.Produtoes", newName: "Produto");
            RenameTable(name: "dbo.Fabricantes", newName: "Fabricante");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Fabricante", newName: "Fabricantes");
            RenameTable(name: "dbo.Produto", newName: "Produtoes");
            RenameTable(name: "dbo.Categoria", newName: "Categorias");
        }
    }
}
