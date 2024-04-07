using MassageCentre.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MassageCentre.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string ?FirstName  { get; set; }
        public string ?LastName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; } = string.Empty;  
        public string? Username { get; set; }
        public Role Role { get; set; }
        public List<Reservation> ?Reservation {  get; set; }
    }
}
