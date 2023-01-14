using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositories.Contracts
{
    public interface ITeamsRepository
    {
        List<Team> GetAllTeamsSP();

        List<Team> GetById(int teamId);
        public List<TopScorersSP> GetTopScores();
        public List<TopScorersSP> GetTopConceeder();

    }
}
