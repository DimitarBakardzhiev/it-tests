namespace IT_Tests.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public Category() 
        {
            this.Questions = new HashSet<Question>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
