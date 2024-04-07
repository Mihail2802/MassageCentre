using MassageCentre.DTOs.UserDTOs;

namespace MassageCentre.Services.Interfaces
{
    public interface IUserInterface
    {
        Task RegisterUser(RegisterUserDto registerUserDto);
        Task<string> LoginUserAsync(LogInUserDto registerUserDto);
        Task ReserveMassage();
    }
}
