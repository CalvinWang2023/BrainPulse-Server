using BrainPulse.Data;
using BrainPulse.Interfaces;
using BrainPulse.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainPulse.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Question> GetAllQuestions()
        {
            return _context.Questions.ToList();
        }

        public ICollection<Question> GetSpecifiedQuestions(int amount, string category, string difficulty, string questionType)
        {
            Random random = new Random();

            return _context.Questions.Include(q => q.Options).Where(q => q.Category == category 
                && q.Difficulty == difficulty 
                && q.QuestionType == questionType).ToList()
                .OrderBy(q => random.Next()).Take(amount).ToList();
        }

        public bool SpecifiedQuestionsExist(int amount, string category, string difficulty, string questionType)
        {
            return _context.Questions.Any(q => q.Category == category
                && q.Difficulty == difficulty
                && q.QuestionType == questionType);
        }
    }
}
