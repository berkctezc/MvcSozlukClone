namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class headingStatusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}