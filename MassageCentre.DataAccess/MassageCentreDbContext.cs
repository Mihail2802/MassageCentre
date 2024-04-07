using MassageCentre.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MassageCentre.DataAccess
{
    public class MassageCentreDbContext : DbContext
    {
        public MassageCentreDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(x => x.FirstName).HasMaxLength(50);
                entity.Property(x => x.LastName).HasMaxLength(50);
                entity.Property(x => x.Email).HasMaxLength(50);
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Role).IsRequired();
            });
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.UserId).IsRequired();
                entity.Property(x => x.TypeOfMassage);
                entity.Property(x => x.Description);
                entity.Property(x => x.Price);
                entity.Property(x => x.StartTime);
                entity.Property(x => x.EndTime);

            });
        }
    }
}
