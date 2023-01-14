namespace WebApplication1.Models.Dto
{
    public class ScoreDto
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public TeamDto TeamName { get; set; }
        public int MatchId { get; set; }
        public MatchDto Match { get; set; }

        public int Value { get; set; }
    }
}
