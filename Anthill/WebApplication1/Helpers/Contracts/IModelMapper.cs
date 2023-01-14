using WebApplication1.Models;
using WebApplication1.Models.Dto;

namespace WebApplication1.Helpers.Contracts
{
    public interface IModelMapper
    {
        public MatchDto MapMatchToDto(Match match);
        public TeamDto MapTeamToDto(Team team);
    }
}
