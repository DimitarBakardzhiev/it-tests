namespace IT_Tests.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Answer
    {
        public Answer() { }

        public int Id { get; set; }

        [Display(Name="Answer Text")]
        public string Text { get; set; }
        
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
