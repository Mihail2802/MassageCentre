using MassageCentre.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace MassageCentre.Domain.Models
{
    public class Massage
    {
        [Key]
        public int Id { get; set; }
        public MassageType TypeOfMassage { get; set; }
        public string ?Description { get; set; }
        public int Price { get; set; }
      
    }
}
