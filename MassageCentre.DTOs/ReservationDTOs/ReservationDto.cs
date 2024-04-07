using MassageCentre.Domain.Enums;
using MassageCentre.DTOs.UserDTOs;
using System.Reflection.Metadata.Ecma335;

namespace MassageCentre.DTOs.ReservationDTOs
{
    public class ReservationDto
    {
        public string Description { get; set; }

        public MassageType TypeofMassage { get; set; }
        public int Price { get; set; }
        public int Durration { get; set; }
       
    }
}
