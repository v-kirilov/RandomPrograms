using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositories.Contracts
{
    public interface IMatchesRepository
    {
        
        List<Match> GetAllMatches();
        Match GetById(int id);
        public List<TopScoredMatch> GetTopScoredMatch();
        
    }
}
