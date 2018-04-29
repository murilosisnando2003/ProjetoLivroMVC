namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajustes : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Cidades");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        CidadeId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CidadeId);
            
        }
    }
}
