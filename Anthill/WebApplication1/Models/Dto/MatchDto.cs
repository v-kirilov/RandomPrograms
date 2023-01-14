namespace WebApplication1.Models.Dto
{
    public class MatchDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public List<string> Teams { get; set; }

    }
}
