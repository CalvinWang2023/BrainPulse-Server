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

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
