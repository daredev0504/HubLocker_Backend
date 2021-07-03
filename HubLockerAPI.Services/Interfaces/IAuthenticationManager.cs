using System.Collections.Generic;
using System.Threading.Tasks;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Services.AuthManager;

namespace HubLockerAPI.Services.Interfaces
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(AppUserAuthDto userForAuth);
        Task<JwtAuthResult> CreateToken();
        Task<IList<string>> getRoles(AppUserAuthDto model);
    }
}
