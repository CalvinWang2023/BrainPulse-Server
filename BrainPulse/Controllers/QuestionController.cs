using BrainPulse.Interfaces;
using BrainPulse.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrainPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Question>))]
        public IActionResult GetAllQuestions()
        {
            var questions = _questionRepository.GetAllQuestions();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(questions);
        }

        [HttpGet("{category}/{difficulty}/{questionType}/{amount}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Question>))]
        [ProducesResponseType(400)]
        public IActionResult GetSpecifiedQuestions(int amount, string category, string difficulty, string questionType)
        {
            if (!_questionRepository.SpecifiedQuestionsExist(amount, category, difficulty, questionType))
                return NotFound();

            var specifiedQuestions = _questionRepository.GetSpecifiedQuestions(amount, category, difficulty, questionType);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(specifiedQuestions);
        }
    }
}
