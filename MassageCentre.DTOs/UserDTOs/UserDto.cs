using MassageCentre.Domain.Enums;

namespace MassageCentre.DTOs.UserDTOs
{
    internal class UserDto
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
    }
}
