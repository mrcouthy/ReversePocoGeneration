namespace MigrationDemo
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddsPetsNameToEngineerPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.engineer_person", "PetsName", c => 
            c.String(nullable:false, maxLength:30, defaultValue:"test"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.engineer_person", "PetsName");
        }
    }
}
