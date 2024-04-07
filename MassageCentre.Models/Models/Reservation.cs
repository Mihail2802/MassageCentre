using MassageCentre.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MassageCentre.Domain.Models
{
    public class Reservation

    {
        [Key]
        public int Id { get; set; }
        public MassageType TypeOfMassage { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
