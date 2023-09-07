using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WinFormsTest.Models;
using WinFormsTest.Models.Enums;

namespace WinFormsTest.Data;

public class ApplicationDbContext : DbContext
{
    // private string _connectionString = "Server=localhost;Port=5432;Database=hci_db;User Id=postgres;Password=adm1n;Pooling=true";
    public DbSet<Club> Club { get; set; }
    public DbSet<BasketballPlayer> BasketballPlayer { get; set; }
    public DbSet<Game> Game { get; set; }
    public DbSet<League> League { get; set; }
    public DbSet<Table> Table { get; set; }
    public DbSet<TableClub> TableClub { get; set; }
    public DbSet<Account> Account { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) 
    { }

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

		builder.Entity<Account>(entity =>
		{
			entity.HasKey(x => x.Id);
			entity.Property(x => x.FirstName).HasMaxLength(50);
			entity.Property(x => x.LastName).HasMaxLength(50);
			entity.Property(x => x.Username);
			entity.Property(x => x.Password);
		});

		// Add seed data for BasketballPlayers
		builder.Entity<BasketballPlayer>().HasData(
			new BasketballPlayer { Id = 1, Name = "Player 1", DressNumber = "23", Position = "Guard", ClubId = 1 },
			new BasketballPlayer { Id = 2, Name = "Player 2", DressNumber = "10", Position = "Forward", ClubId = 1 },
			new BasketballPlayer { Id = 3, Name = "Player 3", DressNumber = "7", Position = "Center", ClubId = 2 },
			new BasketballPlayer { Id = 4, Name = "Player 4", DressNumber = "15", Position = "Guard", ClubId = 2 },
			new BasketballPlayer { Id = 5, Name = "Player 5", DressNumber = "33", Position = "Forward", ClubId = 2 }
		);

        builder.Entity<Account>().HasData(
            new Account { Id = 1, FirstName = "Sergej", LastName = "Soldat", Username = "admin", Password = "admin", Role = Enums.Admin },
            new Account { Id = 2, FirstName = "Sergej", LastName = "Soldat", Username = "user", Password = "user", Role = Enums.User }
        );

			// Add seed data for Clubs
		builder.Entity<Club>().HasData(
			new Club { Id = 1, Name = "Club 1", City = "City 1" },
			new Club { Id = 2, Name = "Club 2", City = "City 2" }
		);

        builder.Entity<Table>().HasData(
            new Table { Id = 1, Season = "2020" },
			new Table { Id = 2, Season = "2021" }
		);
		builder.Entity<TableClub>().HasData(
			new TableClub { TableId=1, ClubId=1, ClubPoints=56 },
			new TableClub { TableId = 2, ClubId = 1, ClubPoints = 55 },
			new TableClub { TableId = 1, ClubId = 2, ClubPoints = 77 },
			new TableClub { TableId = 2, ClubId = 2, ClubPoints = 99 }
		);
	}
}
