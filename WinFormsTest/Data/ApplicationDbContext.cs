using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WinFormsTest.Models;

namespace WinFormsTest.Data
{
    internal class ApplicationDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=BasketBallLeagueDB;Trusted_Connection=True;MultipleActiveResultSets=true";
        public DbSet<Club> Club { get; set; }
        public DbSet<BasketballPlayer> BasketballPlayer { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<TableClub> TableClub { get; set; }

        public ApplicationDbContext()
        {
               
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Club>()
                .HasMany(c => c.BasketballPlayers)
                .WithOne(p => p.Club)
                .HasForeignKey(c => c.ClubId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TableClub>()
                .HasKey(t => new { t.ClubId, t.TableId });

            builder.Entity<Club>()
                .HasMany(x => x.TableClubs)
                .WithOne(x => x.Club)
                .HasForeignKey(x => x.ClubId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Club>()
                .HasMany(x => x.GuestGames)
                .WithOne(x => x.Guest)
                .HasForeignKey(x => x.GuestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Club>()
               .HasMany(x => x.HomeGames)
               .WithOne(x => x.Home)
               .HasForeignKey(x => x.HomeId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Table>()
                .HasMany(x => x.TableClubs)
                .WithOne(x => x.Table)
                .HasForeignKey(x => x.TableId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Table>()
                .HasOne(x => x.League)
                .WithOne(x => x.Table)
                .HasForeignKey<League>(x => x.TableId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
