namespace WebApplication1.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Score> Scores { get; set; }

    }
}
