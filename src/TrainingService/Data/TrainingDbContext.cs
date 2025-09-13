using Microsoft.EntityFrameworkCore;
using TrainingService.Models;

namespace TrainingService.Data
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
            : base(options) { }

        public DbSet<TrainingSession> TrainingSessions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainingSession>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.DistanceKm).IsRequired();
                entity.Property(e => e.Duration).HasConversion(
                    v => v.TotalSeconds,          // store as double seconds
                    v => TimeSpan.FromSeconds(v)
                );
                entity.Property(e => e.TemperatureC);
                entity.Property(e => e.OccurredAt).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
