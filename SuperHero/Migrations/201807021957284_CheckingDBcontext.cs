namespace SuperHero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckingDBcontext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Superheroes", "PrimaryAbility", c => c.String());
            AlterColumn("dbo.Superheroes", "SecondaryAbility", c => c.String());
            AlterColumn("dbo.Superheroes", "Catchprase", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Superheroes", "Catchprase", c => c.Int(nullable: false));
            AlterColumn("dbo.Superheroes", "SecondaryAbility", c => c.Int(nullable: false));
            AlterColumn("dbo.Superheroes", "PrimaryAbility", c => c.Int(nullable: false));
        }
    }
}
