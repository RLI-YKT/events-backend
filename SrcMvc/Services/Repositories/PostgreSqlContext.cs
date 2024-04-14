using Microsoft.EntityFrameworkCore;
using SrcMvc.Models.EventModels;
using SrcMvc.Models.HackathonModels;
using SrcMvc.Models.OlympiadModels;

namespace SrcMvc.Services.Repositories;

public class PostgreSqlContext : DbContext
{
    public PostgreSqlContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=events;username=postgres;password=123456");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Event>()
            .Property(e => e.EventType)
            .HasConversion<string>();
        
        modelBuilder
            .Entity<Comment>()
            .Property(e => e.Status)
            .HasConversion<string>();

        modelBuilder
            .Entity<OlympiadEvent>()
            .Property(e => e.OlympiadLevel)
            .HasConversion<string>();

        modelBuilder
            .Entity<UniversityOlympiad>()
            .Property(e => e.Benefit)
            .HasConversion<string>();
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventDate> EventDates { get; set; }
    public DbSet<EventPhoto> EventPhotos { get; set; }
    public DbSet<EventTrackingTelegram> EventTrackingTelegrams { get; set; }
    public DbSet<HackathonEvent> HackathonEvents { get; set; }
    public DbSet<HackathonOrg> HackathonOrgs { get; set; }
    public DbSet<OlympiadEvent> OlympiadEvents { get; set; }
    public DbSet<OlympiadOrg> OlympiadOrgs { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<UniversityOlympiad> UniversityOlympiads { get; set; }
}