using BrainPulse.Models;

namespace BrainPulse.Interfaces
{
    public interface IOptionRepository
    {
        ICollection<Option> GetAllOptions();
        Option GetOption(int optionId);
        ICollection<Option> GetOptionsFromQuestion(int questionId);
        bool OptionExists(int optionId);
        bool CreateOption(Option option);
        bool UpdateOption(Option option);
        bool DeleteOption(Option option);
        bool Save();
    }
}
