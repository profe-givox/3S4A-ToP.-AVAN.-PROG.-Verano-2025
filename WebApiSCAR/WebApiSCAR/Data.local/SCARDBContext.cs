using Microsoft.EntityFrameworkCore;

namespace WebApiSCAR.Models
{
    public class SCARContext : DbContext
    {
        public SCARContext(DbContextOptions<SCARContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<BitacoraRegistro> BitacorasRegistro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Relación uno a uno entre User y Residente
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Residente)
            //    .WithOne(r => r.User)
            //    .HasForeignKey<Residente>(r => r.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
