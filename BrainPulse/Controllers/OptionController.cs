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

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Option>))]
        public IActionResult GetAllOptions()
        {
            var options = _optionRepository.GetAllOptions();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(options);
        }

        [HttpGet("options/{questionId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Question>))]
        [ProducesResponseType(400)]
        public IActionResult GetOptionsFromQuestion(int questionId)
        {
            if (!_questionRepository.QuestionExists(questionId))
                return NotFound();

            var options = _optionRepository.GetOptionsFromQuestion(questionId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(options);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateOption([FromQuery] int questionId, [FromBody] OptionDto optionCreate)
        {
            if (optionCreate == null)
                return BadRequest(ModelState);

            var question = _questionRepository.GetAllQuestions()
                .Where(q => q.Id == questionId).FirstOrDefault();
            if (question == null)
                return BadRequest(ModelState);

            var option = _optionRepository.GetOptionsFromQuestion(questionId)
                            .Where(o => o.OptionText.Trim().ToUpper() == optionCreate.OptionText.Trim().ToUpper())
                            .FirstOrDefault();
            if (option != null)
            {
                ModelState.AddModelError("", "option already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var optionMap = _mapper.Map<Option>(optionCreate);

            optionMap.Question = _questionRepository.GetQuestion(questionId);

            if (!_optionRepository.CreateOption(optionMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpPut("{questionId}/{optionId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateOption(int questionId, int optionId, [FromBody] OptionDto updatedOption)
        {
            if (updatedOption == null)
                return BadRequest(ModelState);

            var question = _questionRepository.GetAllQuestions()
                .Where(q => q.Id == questionId).FirstOrDefault();
            if (question == null)
                return BadRequest(ModelState);

            if (optionId != updatedOption.Id)
                return BadRequest(ModelState);

            if (!_optionRepository.OptionExists(optionId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var optionMap = _mapper.Map<Option>(updatedOption);

            if (!_optionRepository.UpdateOption(optionMap))
            {
                ModelState.AddModelError("", "Something went wrong updating option");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{questionId}/{optionId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteOption(int questionId, int optionId)
        {
            var question = _questionRepository.GetAllQuestions()
                .Where(q => q.Id == questionId).FirstOrDefault();
            if (question == null)
                return BadRequest(ModelState);

            if (!_optionRepository.OptionExists(optionId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var optionToDelete = _optionRepository.GetOption(optionId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_optionRepository.DeleteOption(optionToDelete))
            {
                ModelState.AddModelError("", "Something went wrong deleting question");
            }

            return NoContent();
        }
    }
}
