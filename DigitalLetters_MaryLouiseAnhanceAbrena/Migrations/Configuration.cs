namespace DigitalLetters_MaryLouiseAnhanceAbrena.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DigitalLetters_MaryLouiseAnhanceAbrena.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DigitalLetters_MaryLouiseAnhanceAbrena.Models.ApplicationDbContext";
        }

        protected override void Seed(DigitalLetters_MaryLouiseAnhanceAbrena.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
