namespace MVCEmployeeManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCEmployeeManagement.EF.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCEmployeeManagement.EF.DataContext context)
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

            context.Departments.AddOrUpdate(
                d => d.Name,

                new Models.Department()
                {
                    Name = "Yazýlým",
                    Description = "Yazýlým Projeleri Geliþtirme Birimi"
                },
                new Models.Department()
                {
                    Name = "Sistem",
                    Description = "Sistem ve Network Destek Birimi"
                },
                new Models.Department()
                {
                    Name = "Grafik",
                    Description = "Grafik ve Tasarým Birimi"
                });



        }
    }
}
