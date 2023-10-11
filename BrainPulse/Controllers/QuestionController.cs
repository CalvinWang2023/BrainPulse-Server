using AutoMapper;
using BrainPulse.Dto;
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
        private readonly IMapper _mapper;

        public QuestionController(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
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

        [HttpGet("{questionId}")]
        [ProducesResponseType(200, Type = typeof(Question))]
        [ProducesResponseType(400)]
        public IActionResult GetQuestion(int questionId)
        {
            if (!_questionRepository.QuestionExist(questionId))
                return NotFound();

            var question = _mapper.Map<QuestionDto>(_questionRepository.GetQuestion(questionId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(question);
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

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateQuestions([FromBody] QuestionDto questionCreate)
        {
            if (questionCreate == null)
                return BadRequest(ModelState);

            var country = _questionRepository.GetAllQuestions()
                .Where(q => q.QuestionText.Trim().ToUpper() == questionCreate.QuestionText.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (country != null)
            {
                ModelState.AddModelError("", "Country already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var questionMap = _mapper.Map<Question>(questionCreate);

            if (!_questionRepository.CreateQuestion(questionMap))
            {
                ModelState.AddModelError("", "Something went wrong while savin");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }
    }
}
