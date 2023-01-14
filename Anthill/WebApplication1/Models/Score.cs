﻿using System.Numerics;

namespace WebApplication1.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }

        public int Value { get; set; }
    }
}
