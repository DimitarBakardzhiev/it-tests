namespace IT_Tests.Data
{
    using System.Data.Entity;

    using IT_Tests.Data.Migrations;
    using IT_Tests.Models;

    using Microsoft.AspNet.Identity.EntityFramework;

    public class ITTestsDbContext : IdentityDbContext<User>
    {
        public ITTestsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ITTestsDbContext, Configuration>());
        }

        public static ITTestsDbContext Create()
        {
            return new ITTestsDbContext();
        }
    }
}
