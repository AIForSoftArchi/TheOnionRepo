using MyApp.Application.Models.DTOs;
using MyApp.Domain.Entities;

namespace MyApp.Application.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToDTO(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailId = user.EmailId,
                Status = (int)user.Status,
                StatusText = user.Status.ToString()
            };
        }
    }
}
