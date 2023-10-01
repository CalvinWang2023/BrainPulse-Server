using System.Text.Json.Serialization;

namespace BrainPulse.Models
{
    public class Option
    {
        public int Id { get; set; }
        public string OptionText { get; set; }

        [JsonIgnore]
        public Question Question { get; set; }
    }
}
