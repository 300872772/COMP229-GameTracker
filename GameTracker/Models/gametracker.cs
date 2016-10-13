namespace GameTracker.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class gametracker : DbContext
    {
        public gametracker()
            : base("name=gametracker")
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchPlayer> MatchPlayers { get; set; }
        public virtual DbSet<MatchStatistic> MatchStatistics { get; set; }
        public virtual DbSet<PointTable> PointTables { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Match>()
                .Property(e => e.Venue)
                .IsUnicode(false);

            modelBuilder.Entity<Match>()
                .Property(e => e.VenueCapacity)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName1C)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName2G)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName3)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName4)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName5)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName6)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName7)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName8)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName9)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName10)
                .IsUnicode(false);

            modelBuilder.Entity<MatchPlayer>()
                .Property(e => e.T1PlayerName11)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Flag)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName1)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName2)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName3)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName4)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName5)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName6)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName7)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName8)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName9)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName10)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName11)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName12)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName13)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName14)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.PlayerName15)
                .IsUnicode(false);

            modelBuilder.Entity<Tournament>()
                .Property(e => e.TournamentName)
                .IsUnicode(false);
        }
    }
}
