namespace IT_Tests.Data.Interfaces
{
    using System.Data.Entity;

    using IT_Tests.Models;

    public interface IITTestsData
    {
        DbContext Context { get; }

        IRepository<Answer> Answers { get; }

        IRepository<Category> Categories { get; }

        IRepository<Question> Questions { get; }

        IRepository<User> Users { get; }

        void Dispose();

        int SaveChanges();
    }
}
