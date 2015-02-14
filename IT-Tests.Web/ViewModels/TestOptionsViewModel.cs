namespace IT_Tests.Web.ViewModels
{
    using IT_Tests.Enumerations;
    using System.ComponentModel.DataAnnotations;

    public class TestOptionsViewModel
    {
        [Display(Name="Questions")]
        [Range(10, 40, ErrorMessage = "Number of Questions must be between {1} and {2}")]
        public int NumberOfQuestions { get; set; }

        public QuestionDifficulty Difficulty { get; set; }

        public bool Timed { get; set; }
    }
}