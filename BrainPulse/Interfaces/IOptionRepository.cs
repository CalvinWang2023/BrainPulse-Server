using BrainPulse.Models;

namespace BrainPulse.Interfaces
{
    public interface IOptionRepository
    {
        bool CreateOption(Option option);
        bool Save();
    }
}
