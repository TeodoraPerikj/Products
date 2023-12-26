namespace Products.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Picture", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Picture", c => c.Binary());
        }
    }
}
