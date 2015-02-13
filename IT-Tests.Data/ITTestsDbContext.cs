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

        public virtual IDbSet<Answer> Answers { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Question> Questions { get; set; }

        public static ITTestsDbContext Create()
        {
            return new ITTestsDbContext();
        }
    }
}
