namespace IT_Tests.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public Category() 
        {
            this.Questions = new HashSet<Question>();
        }

        public int Id { get; set; }

        [Display(Name="Category Name")]
        public string Name { get; set; }

        public bool IsChoosable { get; set; }

        [Display(Name="Parent Category")]
        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
