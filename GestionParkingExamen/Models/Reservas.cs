using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GestionParkingExamen.Models
{
    public class Reservas
    {
        [Key]
        public int id{ get; set; }
        [Required]
        [ForeignKey("Usuario")]
        public string? UsuarioId { get; set; }

        [Required]
        public DateTime fechIni { get; set; }

        public DateTime fechFin { get; set; }
        [JsonIgnore]
        public IdentityUser? Usuario { get; set; }
    }
}
