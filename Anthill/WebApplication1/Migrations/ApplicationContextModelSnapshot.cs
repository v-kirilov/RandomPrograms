﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication1.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 4,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 5,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 6,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 7,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 8,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 9,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 10,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 11,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 12,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 13,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 14,
                            Status = "Played"
                        },
                        new
                        {
                            Id = 15,
                            Status = "Played"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("TeamId");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MatchId = 1,
                            TeamId = 1,
                            Value = 100
                        },
                        new
                        {
                            Id = 2,
                            MatchId = 1,
                            TeamId = 2,
                            Value = 90
                        },
                        new
                        {
                            Id = 3,
                            MatchId = 2,
                            TeamId = 1,
                            Value = 85
                        },
                        new
                        {
                            Id = 4,
                            MatchId = 2,
                            TeamId = 3,
                            Value = 95
                        },
                        new
                        {
                            Id = 5,
                            MatchId = 3,
                            TeamId = 1,
                            Value = 80
                        },
                        new
                        {
                            Id = 6,
                            MatchId = 3,
                            TeamId = 4,
                            Value = 95
                        },
                        new
                        {
                            Id = 7,
                            MatchId = 14,
                            TeamId = 1,
                            Value = 82
                        },
                        new
                        {
                            Id = 8,
                            MatchId = 14,
                            TeamId = 5,
                            Value = 93
                        },
                        new
                        {
                            Id = 9,
                            MatchId = 4,
                            TeamId = 1,
                            Value = 90
                        },
                        new
                        {
                            Id = 10,
                            MatchId = 4,
                            TeamId = 6,
                            Value = 78
                        },
                        new
                        {
                            Id = 11,
                            MatchId = 5,
                            TeamId = 2,
                            Value = 99
                        },
                        new
                        {
                            Id = 12,
                            MatchId = 5,
                            TeamId = 3,
                            Value = 77
                        },
                        new
                        {
                            Id = 13,
                            MatchId = 6,
                            TeamId = 2,
                            Value = 80
                        },
                        new
                        {
                            Id = 14,
                            MatchId = 6,
                            TeamId = 4,
                            Value = 95
                        },
                        new
                        {
                            Id = 15,
                            MatchId = 7,
                            TeamId = 2,
                            Value = 90
                        },
                        new
                        {
                            Id = 16,
                            MatchId = 7,
                            TeamId = 5,
                            Value = 78
                        },
                        new
                        {
                            Id = 17,
                            MatchId = 8,
                            TeamId = 2,
                            Value = 95
                        },
                        new
                        {
                            Id = 18,
                            MatchId = 8,
                            TeamId = 6,
                            Value = 74
                        },
                        new
                        {
                            Id = 29,
                            MatchId = 9,
                            TeamId = 3,
                            Value = 88
                        },
                        new
                        {
                            Id = 30,
                            MatchId = 9,
                            TeamId = 4,
                            Value = 69
                        },
                        new
                        {
                            Id = 19,
                            MatchId = 10,
                            TeamId = 3,
                            Value = 94
                        },
                        new
                        {
                            Id = 20,
                            MatchId = 10,
                            TeamId = 5,
                            Value = 73
                        },
                        new
                        {
                            Id = 21,
                            MatchId = 11,
                            TeamId = 3,
                            Value = 111
                        },
                        new
                        {
                            Id = 22,
                            MatchId = 11,
                            TeamId = 6,
                            Value = 110
                        },
                        new
                        {
                            Id = 23,
                            MatchId = 12,
                            TeamId = 4,
                            Value = 86
                        },
                        new
                        {
                            Id = 24,
                            MatchId = 12,
                            TeamId = 5,
                            Value = 75
                        },
                        new
                        {
                            Id = 25,
                            MatchId = 13,
                            TeamId = 4,
                            Value = 100
                        },
                        new
                        {
                            Id = 26,
                            MatchId = 13,
                            TeamId = 6,
                            Value = 78
                        },
                        new
                        {
                            Id = 27,
                            MatchId = 15,
                            TeamId = 5,
                            Value = 91
                        },
                        new
                        {
                            Id = 28,
                            MatchId = 15,
                            TeamId = 6,
                            Value = 71
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lakers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bulls"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Warriors"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Celtics"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nets"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Mavericks"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.TopScoredMatch", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("Score1")
                        .HasColumnType("int");

                    b.Property<int>("Score2")
                        .HasColumnType("int");

                    b.Property<int>("Team1")
                        .HasColumnType("int");

                    b.Property<string>("Team1Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team2")
                        .HasColumnType("int");

                    b.Property<string>("Team2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.ToTable("TopMatch");
                });

            modelBuilder.Entity("WebApplication1.Models.TopScorersSP", b =>
                {
                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.ToTable("TopScorersSP");
                });

            modelBuilder.Entity("WebApplication1.Models.Score", b =>
                {
                    b.HasOne("WebApplication1.Models.Match", "Match")
                        .WithMany("Scores")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Team", "Team")
                        .WithMany("Scores")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WebApplication1.Models.Match", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("WebApplication1.Models.Team", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
