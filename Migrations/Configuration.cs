namespace WebFormNovice1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebFormNovice1.Models.DBModel>
    {
        public Configuration()
        {
            //設定自動Migrations
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebFormNovice1.Models.DBModel";
        }

        protected override void Seed(WebFormNovice1.Models.DBModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
