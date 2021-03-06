namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class contentStatusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentStatus", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Contents", "ContentStatus");
        }
    }
}