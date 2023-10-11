using BrainPulse.Data;
using BrainPulse.Interfaces;
using BrainPulse.Models;

namespace BrainPulse.Repository
{
    public class OptionRepository : IOptionRepository
    {
        private readonly DataContext _context;

        public OptionRepository(DataContext context)
        {
            _context = context;
        }
        public bool CreateOption(Option option)
        {
            _context.Add(option);
            return Save();
        }

        public bool DeleteOption(Option option)
        {
            _context.Remove(option);
            return Save();
        }

        public ICollection<Option> GetAllOptions()
        {
            return _context.Options.ToList();
        }

        public Option GetOption(int optionId)
        {
            return _context.Options.Where(o => o.Id == optionId).FirstOrDefault();
        }

        public ICollection<Option> GetOptionsFromQuestion(int questionId)
        {
            return _context.Options.Where(o => o.Question.Id == questionId).ToList();
        }

        public bool OptionExists(int optionId)
        {
            return _context.Options.Any(o => o.Id == optionId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateOption(Option option)
        {
            _context.Update(option);
            return Save();
        }
    }
}
