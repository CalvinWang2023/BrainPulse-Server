namespace BrainPulse.Models
{
    public class Option
    {
        public int Id { get; set; }
        public string OptionText { get; set; }
        public Question Question { get; set; }
    }
}
