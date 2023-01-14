using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    //[Keyless]
    public class TopScoredMatch
    {
        public int MatchId { get; set; }
        public string Team1Name { get; set; }
        public int Team1 { get; set; }
        public int Score1 { get; set; }
        public string Team2Name { get; set; }
        public int Team2 { get; set; }
        public int Score2 { get; set; }
        public int Total { get; set; }

    }
}
