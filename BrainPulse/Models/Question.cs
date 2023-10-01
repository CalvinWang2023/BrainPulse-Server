namespace BrainPulse.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public ICollection<Option> Options { get; set; }
        public string Difficulty { get; set; }
        public string QuestionType { get; set; }
        public string Category { get; set; }
    }
}
