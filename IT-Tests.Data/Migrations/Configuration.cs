namespace IT_Tests.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using IT_Tests.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<ITTestsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ITTestsDbContext context)
        {
            // This method will be called after migrating to the latest version.
            // You can use the DbSet<T>.AddOrUpdate() helper extension method 
            // to avoid creating duplicate seed data. E.g.
            //
            //   context.People.AddOrUpdate(
            //     p => p.FullName,
            //     new Person { FullName = "Andrew Peters" },
            //     new Person { FullName = "Brice Lambson" },
            //     new Person { FullName = "Rowan Miller" }
            //   );
            const string AdminRole = "Admin";
            const string AdminUsername = "Stracmana@frontend.com";
            const string AdminPassword = "biqsesloshite";

            context.Roles.AddOrUpdate(r => r.Name, new IdentityRole(AdminRole));

            if (!context.Users.Any(u => u.UserName == AdminUsername))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User { UserName = AdminUsername, Email = AdminUsername, Points = 0 };

                manager.Create(user, AdminPassword);
                manager.AddToRole(user.Id, AdminRole);
                context.SaveChanges();
            }
        }
    }
}
