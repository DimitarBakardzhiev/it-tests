namespace IT_Tests.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        public Question() 
        {
            this.Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }

        [Display(Name="Question Text")]
        public string Text { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
