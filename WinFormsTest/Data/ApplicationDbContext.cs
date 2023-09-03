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
        private string _connectionString = "Server=localhost;Port=5432;Database=hci_db;User Id=postgres;Password=adm1n;Pooling=true";
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
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BasketballPlayer>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).HasMaxLength(50);
                entity.Property(x => x.DressNumber).HasMaxLength(50);
                entity.Property(x => x.Position).HasMaxLength(50);

                entity
                .HasOne(x => x.Club)
                .WithMany(x => x.BasketballPlayers)
                .HasForeignKey(x => x.ClubId);
            });

            builder.Entity<Club>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).HasMaxLength(50);
                entity.Property(x => x.City).HasMaxLength(50);

                entity
                .HasMany(x => x.HomeGames)
                .WithOne(x => x.Home)
                .HasForeignKey(x => x.HomeId);


                entity
                .HasMany(x => x.GuestGames)
                .WithOne(x => x.Guest)
                .HasForeignKey(x => x.GuestId);

                entity
                .HasMany(x => x.Tables)
                .WithMany(x => x.Clubs)
                .UsingEntity<TableClub>(
                        l => l.HasOne<Table>().WithMany().HasForeignKey(e => e.TableId),
                        r => r.HasOne<Club>().WithMany().HasForeignKey(e => e.ClubId)
                    );
            });

            builder.Entity<Game>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.City).HasMaxLength(50);
                entity.Property(x => x.Arena).HasMaxLength(50);
                entity.Property(x => x.GuestPoints);
                entity.Property(x => x.HomePoints);
            });

			builder.Entity<League>(entity =>
			{
				entity.HasKey(x => x.Id);
                entity.Property(x => x.State).HasMaxLength(50);
                entity.Property(x => x.Name).HasMaxLength(50);


				entity
                .HasOne(x => x.Table)
                .WithOne(x => x.League);      
			});

			builder.Entity<Table>(entity =>
			{
				entity.HasKey(x => x.Id);
                entity.Property(x => x.Season).HasMaxLength(50);

			});

			builder.Entity<TableClub>(entity =>
			{
                entity.HasKey(x => new { x.TableId, x.ClubId });
				entity.Property(x => x.ClubPoints);

			});
		}

	}
}
