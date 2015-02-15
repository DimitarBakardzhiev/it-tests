namespace IT_Tests.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using IT_Tests.Data.Interfaces;
    using IT_Tests.Models;

    public class ITTestsData : IITTestsData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public ITTestsData(DbContext context)
        {
            this.context = context;
        }

        public IRepository<Answer> Answers 
        {
            get 
            {
                return this.GetRepository<Answer>();
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                return this.GetRepository<Category>();
            }
        }

        public IRepository<Question> Questions 
        {
            get 
            {
                return this.GetRepository<Question>();
            }
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public DbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
