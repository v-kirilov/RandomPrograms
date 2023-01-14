using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System;

namespace WebApplication1.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<TopScoredMatch> TopMatch { get; set; }
        public DbSet<TopScorersSP> TopScorersSP { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            List<Team> teams = new List<Team>
            {
                new Team
                {
                    Id=1,
                    Name="Lakers"
                },
                new Team
                {
                    Id=2,
                    Name="Bulls"
                },
                new Team
                {
                    Id=3,
                    Name="Warriors"
                },
                new Team
                {
                    Id=4,
                    Name="Celtics"
                },
                new Team
                {
                    Id=5,
                    Name="Nets"
                },
                new Team
                {
                    Id=6,
                    Name="Mavericks"
                }
            };
            modelBuilder.Entity<Team>().HasData(teams);

            List<Match> matches = new List<Match>
            {
                new Match
                {
                    Id=1,
                    Status="Played"
                },new Match
                {
                    Id=2,
                    Status="Played"

                },new Match
                {
                    Id=3,
                    Status="Played"

                },new Match
                {
                    Id=4,
                    Status="Played"

                },new Match
                {
                    Id=5,
                    Status="Played"

                },new Match
                {
                    Id=6,
                    Status="Played"

                },new Match
                {
                    Id=7,
                    Status="Played"

                },new Match
                {
                    Id=8,
                    Status="Played"

                },new Match
                {
                    Id=9,
                    Status="Played"

                },new Match
                {
                    Id=10,
                    Status="Played"

                },new Match
                {
                    Id=11,
                    Status="Played"

                },new Match
                {
                    Id=12,
                    Status="Played"

                },new Match
                {
                    Id=13,
                    Status="Played"

                },new Match
                {
                    Id=14,
                    Status="Played"

                },new Match
                {
                    Id=15,
                    Status="Played"

                }
            };
            modelBuilder.Entity<Match>().HasData(matches);

            List<Score> scores = new List<Score>()
            {
                new Score(){ Id=1, TeamId=1, MatchId=1,Value=100},
                new Score(){ Id=2, TeamId=2, MatchId=1,Value=90},

                new Score(){ Id=3, TeamId=1, MatchId=2,Value=85},
                new Score(){ Id=4, TeamId=3, MatchId=2,Value=95},

                new Score(){ Id=5, TeamId=1, MatchId=3,Value=80},
                new Score(){ Id=6, TeamId=4, MatchId=3,Value=95},

                new Score(){ Id=7, TeamId=1, MatchId=14,Value=82},
                new Score(){ Id=8, TeamId=5, MatchId=14,Value=93},

                new Score(){ Id=9, TeamId=1, MatchId=4,Value=90},
                new Score(){ Id=10, TeamId=6, MatchId=4,Value=78},

                new Score(){ Id=11, TeamId=2, MatchId=5,Value=99},
                new Score(){ Id=12, TeamId=3, MatchId=5,Value=77},

                 new Score(){ Id=13, TeamId=2, MatchId=6,Value=80},
                new Score(){ Id=14, TeamId=4, MatchId=6,Value=95},

                new Score(){ Id=15, TeamId=2, MatchId=7,Value=90},
                new Score(){ Id=16, TeamId=5, MatchId=7,Value=78},

                new Score(){ Id=17, TeamId=2, MatchId=8,Value=95},
                new Score(){ Id=18, TeamId=6, MatchId=8,Value=74},

                new Score(){ Id=29, TeamId=3, MatchId=9,Value=88},
                new Score(){ Id=30, TeamId=4, MatchId=9,Value=69},

                new Score(){ Id=19, TeamId=3, MatchId=10,Value=94},
                new Score(){ Id=20, TeamId=5, MatchId=10,Value=73},

                new Score(){ Id=21, TeamId=3, MatchId=11,Value=111},
                new Score(){ Id=22, TeamId=6, MatchId=11,Value=110},

                new Score(){ Id=23, TeamId=4, MatchId=12,Value=86},
                new Score(){ Id=24, TeamId=5, MatchId=12,Value=75},

                 new Score(){ Id=25, TeamId=4, MatchId=13,Value=100},
                new Score(){ Id=26, TeamId=6, MatchId=13,Value=78},

                 new Score(){ Id=27, TeamId=5, MatchId=15,Value=91},
                new Score(){ Id=28, TeamId=6, MatchId=15,Value=71},
            };
            modelBuilder.Entity<Score>().HasData(scores);


            //List<TopScoredMatch> topMatch = new List<TopScoredMatch>()
            //{
              
            //};
            //modelBuilder.Entity<TopScoredMatch>().HasData(topMatch);
            modelBuilder.Entity<TopScoredMatch>().HasNoKey();
            modelBuilder.Entity<TopScorersSP>().HasNoKey();


        }
    }
}
