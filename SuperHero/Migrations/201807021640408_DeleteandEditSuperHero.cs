namespace SuperHero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteandEditSuperHero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Superheroes", "AlterEgo", c => c.String());
            AddColumn("dbo.Superheroes", "PrimaryAbility", c => c.Int(nullable: false));
            AddColumn("dbo.Superheroes", "SecondaryAbility", c => c.Int(nullable: false));
            AddColumn("dbo.Superheroes", "Catchprase", c => c.Int(nullable: false));
            DropColumn("dbo.Superheroes", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Superheroes", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.Superheroes", "Catchprase");
            DropColumn("dbo.Superheroes", "SecondaryAbility");
            DropColumn("dbo.Superheroes", "PrimaryAbility");
            DropColumn("dbo.Superheroes", "AlterEgo");
        }
    }
}
