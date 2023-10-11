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
    public class OptionController : ControllerBase
    {
        private readonly IOptionRepository _optionRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public OptionController(IOptionRepository optionRepository, IQuestionRepository questionRepository, IMapper mapper)
        {
            _optionRepository = optionRepository;
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateQuestions([FromQuery] int questionId, [FromBody] OptionDto optionCreate)
        {
            if (optionCreate == null)
                return BadRequest(ModelState);

            //var country = _optionRepository.GetAllQuestions()
            //    .Where(c => c.QuestionText.Trim().ToUpper() == questionCreate.QuestionText.TrimEnd().ToUpper())
            //    .FirstOrDefault();

            //if (country != null)
            //{
            //    ModelState.AddModelError("", "Country already exists");
            //    return StatusCode(422, ModelState);
            //}

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var optionMap = _mapper.Map<Option>(optionCreate);

            optionMap.Question = _questionRepository.GetQuestion(questionId);

            if (!_optionRepository.CreateOption(optionMap))
            {
                ModelState.AddModelError("", "Something went wrong while savin");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }
    }
}
