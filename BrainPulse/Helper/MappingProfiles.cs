using AutoMapper;
using BrainPulse.Dto;
using BrainPulse.Models;

namespace BrainPulse.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Option, OptionDto>();
            CreateMap<OptionDto, Option>();
            CreateMap<Question, QuestionDto>();
            CreateMap<QuestionDto, Question>();
        }
    }
}
