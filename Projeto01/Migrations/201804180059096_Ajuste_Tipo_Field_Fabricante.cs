namespace Projeto01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajuste_Tipo_Field_Fabricante : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fabricantes", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fabricantes", "Nome", c => c.Int(nullable: false));
        }
    }
}
