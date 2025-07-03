using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSCAR.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public Residente? Residente { get; set; }
    }

    public class Residente
    {
        
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con User
        
        [Key,ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class Invitado
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaVisita { get; set; }

        [Required]
        public string Token { get; set; }

        // Relación con Residente
        [ForeignKey("Residente")]
        public int ResidenteId { get; set; }
        public Residente Residente { get; set; }
    }

    public class BitacoraRegistro
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime? FechaHoraSalida { get; set; }

        // Puede ser residente o invitado
        public int? ResidenteId { get; set; }
        public Residente Residente { get; set; }

        public int? InvitadoId { get; set; }
        public Invitado Invitado { get; set; }
    }
}
