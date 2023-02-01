using Core.DTO.OptionDTO;

namespace Core.Interfaces.Services;

public interface IOptionService
{
   Task CreateOption(CreateOptionDTO createOptionDTO, int questionId);
}