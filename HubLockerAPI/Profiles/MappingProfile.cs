using AutoMapper;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Profiles
{
    /// <summary>
    /// 
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public MappingProfile()
        {
            // source => target
            //appUser
            
            CreateMap<AppUser, AppUserReadDto>()
                .ForMember(c => c.Name, opt =>
                    opt.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));
            CreateMap<AppUser, AppUserUpdateDto>();
            CreateMap<AppUserUpdateDto, AppUser>();
            CreateMap<AppUserCreateDto, AppUser>();


            //locker
            CreateMap<Locker, LockerReadDto>();
            CreateMap<LockerCreateDto, Locker>();
            CreateMap<Locker, LockerCreateDto>();
            CreateMap<LockerUpdateDto, Locker>();

            //location
            CreateMap<Location, LocationReadDto>();
            CreateMap<LocationCreateDto, Location>();
            CreateMap<Location, LocationCreateDto>();
            CreateMap<LocationUpdateDto, Location>();

        }
    }
}
