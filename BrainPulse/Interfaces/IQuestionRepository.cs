using BrainPulse.Models;

namespace BrainPulse.Interfaces
{
    public interface IQuestionRepository
    {
        ICollection<Question> GetAllQuestions();
        ICollection<Question> GetSpecifiedQuestions(int amount, string category, string difficulty, string questionType);
        bool SpecifiedQuestionsExist(int amount, string category, string difficulty, string questionType);
    }
}
