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
            // Creates the database if not exists
            

            //// Relación uno a uno entre User y Residente
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Residente)
            //    .WithOne(r => r.User)
            //    .HasForeignKey<Residente>(r => r.UserId);

            // Datos dummy para User
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "user1", Password = "pass1" },
                new User { Id = 2, Username = "user2", Password = "pass2" },
                new User { Id = 3, Username = "user3", Password = "pass3" },
                new User { Id = 4, Username = "user4", Password = "pass4" },
                new User { Id = 5, Username = "user5", Password = "pass5" }
            );

            // Datos dummy para Residente (UserId debe coincidir con User.Id)
            modelBuilder.Entity<Residente>().HasData(
                new Residente { UserId = 1, Nombre = "Juan", Apellido = "Pérez", Email = "juan1@mail.com", Telefono = "1111111", Direccion = "Calle 1", FechaNacimiento = new DateTime(1990, 1, 1), FechaRegistro = DateTime.Now },
                new Residente { UserId = 2, Nombre = "Ana", Apellido = "García", Email = "ana2@mail.com", Telefono = "2222222", Direccion = "Calle 2", FechaNacimiento = new DateTime(1991, 2, 2), FechaRegistro = DateTime.Now },
                new Residente { UserId = 3, Nombre = "Luis", Apellido = "Martínez", Email = "luis3@mail.com", Telefono = "3333333", Direccion = "Calle 3", FechaNacimiento = new DateTime(1992, 3, 3), FechaRegistro = DateTime.Now },
                new Residente { UserId = 4, Nombre = "Sofía", Apellido = "López", Email = "sofia4@mail.com", Telefono = "4444444", Direccion = "Calle 4", FechaNacimiento = new DateTime(1993, 4, 4), FechaRegistro = DateTime.Now },
                new Residente { UserId = 5, Nombre = "Carlos", Apellido = "Ruiz", Email = "carlos5@mail.com", Telefono = "5555555", Direccion = "Calle 5", FechaNacimiento = new DateTime(1994, 5, 5), FechaRegistro = DateTime.Now }
            );

            // Datos dummy para Invitado
            modelBuilder.Entity<Invitado>().HasData(
                new Invitado { Id = 1, Nombre = "Inv1", Apellido = "Ap1", Email = "inv1@mail.com", Telefono = "1000001", FechaVisita = DateTime.Now, Token = "token1", ResidenteId = 1 },
                new Invitado { Id = 2, Nombre = "Inv2", Apellido = "Ap2", Email = "inv2@mail.com", Telefono = "1000002", FechaVisita = DateTime.Now, Token = "token2", ResidenteId = 2 },
                new Invitado { Id = 3, Nombre = "Inv3", Apellido = "Ap3", Email = "inv3@mail.com", Telefono = "1000003", FechaVisita = DateTime.Now, Token = "token3", ResidenteId = 3 },
                new Invitado { Id = 4, Nombre = "Inv4", Apellido = "Ap4", Email = "inv4@mail.com", Telefono = "1000004", FechaVisita = DateTime.Now, Token = "token4", ResidenteId = 4 },
                new Invitado { Id = 5, Nombre = "Inv5", Apellido = "Ap5", Email = "inv5@mail.com", Telefono = "1000005", FechaVisita = DateTime.Now, Token = "token5", ResidenteId = 5 }
            );

            // Datos dummy para BitacoraRegistro
            modelBuilder.Entity<BitacoraRegistro>().HasData(
                new BitacoraRegistro { Id = 1, FechaHoraEntrada = DateTime.Now.AddHours(-5), FechaHoraSalida = DateTime.Now.AddHours(-4), ResidenteId = 1, InvitadoId = null },
                new BitacoraRegistro { Id = 2, FechaHoraEntrada = DateTime.Now.AddHours(-3), FechaHoraSalida = DateTime.Now.AddHours(-2), ResidenteId = 2, InvitadoId = null },
                new BitacoraRegistro { Id = 3, FechaHoraEntrada = DateTime.Now.AddHours(-1), FechaHoraSalida = null, ResidenteId = 3, InvitadoId = null },
                new BitacoraRegistro { Id = 4, FechaHoraEntrada = DateTime.Now.AddHours(-6), FechaHoraSalida = DateTime.Now.AddHours(-5), ResidenteId = null, InvitadoId = 1 },
                new BitacoraRegistro { Id = 5, FechaHoraEntrada = DateTime.Now.AddHours(-7), FechaHoraSalida = DateTime.Now.AddHours(-6), ResidenteId = null, InvitadoId = 2 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
