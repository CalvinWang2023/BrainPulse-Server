using BrainPulse.Models;

namespace BrainPulse.Interfaces
{
    public interface IQuestionRepository
    {
        ICollection<Question> GetAllQuestions();
        Question GetQuestion(int questionId);
        bool QuestionExists(int questionId);
        ICollection<Question> GetSpecifiedQuestions(int amount, string category, string difficulty, string questionType);
        bool SpecifiedQuestionsExist(int amount, string category, string difficulty, string questionType);
        bool CreateQuestion(Question question);
        bool UpdateQuestion(Question question);
        bool DeleteQuestion(Question question);
        bool Save();
    }
}
