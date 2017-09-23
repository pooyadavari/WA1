namespace WA1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(new Models.Product { Title = "Product1", Price = 100 });
            context.Products.AddOrUpdate(new Models.Product { Title = "Product2", Price = 200 });
            context.Products.AddOrUpdate(new Models.Product { Title = "Product3", Price = 300 });
            context.Products.AddOrUpdate(new Models.Product { Title = "Product4", Price = 400 });

        }
    }
}
