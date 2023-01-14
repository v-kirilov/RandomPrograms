using WebApplication1.Helpers.Contracts;
using WebApplication1.Models;
using WebApplication1.Models.Dto;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Helpers
{
    public class ModelMapper : IModelMapper
    {
        private readonly ITeamsRepository teamsRepository;
        public ModelMapper(ITeamsRepository teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public MatchDto MapMatchToDto(Match match)
        {
            List<Team> teams = match.Scores.Select(x => x.Team).ToList();
            Team team1 = teams[0];
            Team team2 = teams[1];
            return new MatchDto
            {
                Id = match.Id,
                Status = match.Status,
                Score1 = match.Scores.Where(x => x.TeamId == team1.Id).Select(x => x.Value).First(),
                Score2 = match.Scores.Where(x => x.TeamId == team1.Id).Select(x => x.Value).First(),
                Teams = match.Scores.Select(x => x.Team.Name).ToList(),
            };
        }

        public TeamDto MapTeamToDto(Team team)
        {
            return new TeamDto
            {
                Id = team.Id,
                Name=team.Name
            };
        }

    }
}
