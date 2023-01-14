using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Repositories
{
    public class MatchesRepository : IMatchesRepository
    {
        private readonly ApplicationContext context;

        public MatchesRepository(ApplicationContext context)
        {
            this.context = context;
        }

        
        private IQueryable<TopScoredMatch> GetTopScoredMatchSP()
        {
            return this.context
                .Set<TopScoredMatch>()
                .FromSqlRaw("GetTopMatch");
        }

        private IQueryable<Match> GetMatches()
        {
            return this.context.Matches
                .Include(x => x.Scores)
                .ThenInclude(x=>x.Team);
        }
        public List<TopScoredMatch> GetTopScoredMatch()
        {
            return this.GetTopScoredMatchSP().ToList();
        }

        
        public List<Match> GetAllMatches()
        {
            return this.GetMatches().ToList();
        }

        public Match GetById(int id)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
