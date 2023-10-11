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

        public bool CreateQuestion(Question question)
        {
            _context.Add(question);
            return Save();
        }

        public bool DeleteQuestion(Question question)
        {
            _context.Remove(question);
            return Save();
        }

        public ICollection<Question> GetAllQuestions()
        {
            return _context.Questions.ToList();
        }

        public Question GetQuestion(int questionId)
        {
            return _context.Questions.Where(q => q.Id == questionId).FirstOrDefault();
        }

        public ICollection<Question> GetSpecifiedQuestions(int amount, string category, string difficulty, string questionType)
        {
            Random random = new Random();

            return _context.Questions.Include(q => q.Options).Where(q => q.Category == category 
                && q.Difficulty == difficulty 
                && q.QuestionType == questionType).ToList()
                .OrderBy(q => random.Next()).Take(amount).ToList();
        }

        public bool QuestionExists(int questionId)
        {
            return _context.Questions.Any(q => q.Id == questionId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool SpecifiedQuestionsExist(int amount, string category, string difficulty, string questionType)
        {
            return _context.Questions.Any(q => q.Category == category
                && q.Difficulty == difficulty
                && q.QuestionType == questionType);
        }

        public bool UpdateQuestion(Question question)
        {
            _context.Update(question);
            return Save();
        }
    }
}
