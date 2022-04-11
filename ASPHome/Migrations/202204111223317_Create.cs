namespace ASPHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Documents", "PanCard", c => c.Binary());
            AlterColumn("dbo.Documents", "VoterId", c => c.Binary());
            AlterColumn("dbo.Documents", "SalarySlip", c => c.Binary());
            AlterColumn("dbo.Documents", "LOA", c => c.Binary());
            AlterColumn("dbo.Documents", "NOCFromBuilder", c => c.Binary());
            AlterColumn("dbo.Documents", "AgreementToSale", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Documents", "AgreementToSale", c => c.Binary(nullable: false));
            AlterColumn("dbo.Documents", "NOCFromBuilder", c => c.Binary(nullable: false));
            AlterColumn("dbo.Documents", "LOA", c => c.Binary(nullable: false));
            AlterColumn("dbo.Documents", "SalarySlip", c => c.Binary(nullable: false));
            AlterColumn("dbo.Documents", "VoterId", c => c.Binary(nullable: false));
            AlterColumn("dbo.Documents", "PanCard", c => c.Binary(nullable: false));
        }
    }
}
