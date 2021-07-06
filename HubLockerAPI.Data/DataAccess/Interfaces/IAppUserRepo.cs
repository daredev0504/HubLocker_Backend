using HubLockerAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Helper.RequestFeatures;

namespace HubLockerAPI.Data.DataAccess.Interfaces
{
    public interface IAppUserRepo 
    {
        Task<PagedList<AppUser>> GetAppUsersAsync();
        Task<AppUser> GetAppUserAsync(Guid appUserId);
        void CreateAppUser(AppUser appUser);
        void DeleteAppUser(AppUser appUser);
        void UpdateAppUser(AppUser appUser);
    }
}
