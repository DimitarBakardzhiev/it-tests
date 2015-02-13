namespace IT_Tests.Models
{
    public class Answer
    {
        public Answer() { }

        public int Id { get; set; }

        public string Text { get; set; }
        
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
