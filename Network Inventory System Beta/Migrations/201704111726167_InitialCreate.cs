namespace Network_Inventory_System_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItdId = c.String(),
                        SerialNumber = c.String(),
                        Location = c.String(),
                        Manufacturer = c.String(),
                        PartNumber = c.String(),
                        ModelNumber = c.String(),
                        Confirmed = c.String(),
                        Comments = c.String(),
                        AssetNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InventoryItems");
        }
    }
}
