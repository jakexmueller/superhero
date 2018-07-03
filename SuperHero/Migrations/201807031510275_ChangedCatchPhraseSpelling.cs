namespace SuperHero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCatchPhraseSpelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Superheroes", "CatchPhrase", c => c.String());
            DropColumn("dbo.Superheroes", "Catchprase");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Superheroes", "Catchprase", c => c.String());
            DropColumn("dbo.Superheroes", "CatchPhrase");
        }
    }
}
