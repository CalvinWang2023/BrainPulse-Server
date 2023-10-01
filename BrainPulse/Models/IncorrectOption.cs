namespace BrainPulse.Models
{
    public class IncorrectOption
    {
        public int Id { get; set; }
        public string IncorrectOptionText { get; set; }
        public Question Question { get; set; }
    }
}
