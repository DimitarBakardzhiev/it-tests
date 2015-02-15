namespace IT_Tests.Data.Migrations
{
    using IT_Tests.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IT_Tests.Data.ITTestsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(IT_Tests.Data.ITTestsDbContext context)
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

            const string AdminRole = "Admin";

            /*const string AdminUsername = "admin@it-tests.net";
            const string AdminPassword = "biqsesloshite";*/

            //you may need to run this independatly cause of microsoft's identity's asyncness
            context.Roles.AddOrUpdate(r => r.Name, new IdentityRole(AdminRole));

            /*if (!context.Users.Any(u => u.UserName == AdminUsername))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User { UserName = AdminUsername, Email = AdminUsername, Points = 0 };

                manager.Create(user, AdminPassword);
                manager.AddToRole(user.Id, AdminRole);
                context.SaveChanges();
            }*/

            var firstUserId = context.Users.First().Id;
            var store = new UserStore<User>(context);
            var manager = new UserManager<User>(store);
            manager.AddToRole(firstUserId, AdminRole);
        }
    }
}
