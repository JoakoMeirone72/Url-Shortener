using Url_Shortener.Entities;
using Url_Shortener.Models;

namespace Url_Shortener.Services.Interfaces
{
    public interface IUserService
    {
        void Create(CreateUserDto dto);

        User? ValidateUser(AuthenticationRequestBody authRequestBody);
    }
}
