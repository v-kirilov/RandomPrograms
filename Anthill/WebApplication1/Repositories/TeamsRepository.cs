using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Repositories
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly ApplicationContext context;

        public TeamsRepository(ApplicationContext context)
        {
            this.context = context;
        }

        private IQueryable<Team> GetTeams()
        {
            return this.context
                .Set<Team>()
                .FromSqlRaw("AllTeams");

        }
        public List<Team> GetAllTeamsSP()
        {
            return this.GetTeams().ToList();
        }

        private IQueryable<Team> GetTeamByIdSP(int teamId)
        {
            return this.context
                .Set<Team>()
                .FromSqlRaw($"TeamById {teamId}");
        }
        public List<Team> GetById(int teamId)
        {
            return this.GetTeamByIdSP(teamId).ToList();
        }

        private IQueryable<TopScorersSP> GetTopScoresSP()
        {
            return this.context
                .Set<TopScorersSP>()
                .FromSqlRaw("GetTopScorers");
        }
        private IQueryable<TopScorersSP> GetTopConceederSP()
        {
            return this.context
                .Set<TopScorersSP>()
                .FromSqlRaw("GetTopConceederSP");
        }

        public List<TopScorersSP> GetTopScores()
        {
            return this.GetTopScoresSP().ToList();
        }
        public List<TopScorersSP> GetTopConceeder()
        {
            return this.GetTopConceederSP().ToList();
        }
    }
}
