namespace WebApplication1.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public List<Score> Scores { get; set; }
    }
}
