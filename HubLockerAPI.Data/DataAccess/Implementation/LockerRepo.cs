using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HubLockerAPI.Data.Data;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HubLockerAPI.Data.DataAccess.Implementation
{
    public class LockerRepo : GenericRepository<Locker>, ILockerRepo
    {
        private readonly ApplicationDbContext _ctx;
        private readonly IMapper _mapper;

        public LockerRepo(ApplicationDbContext ctx, IMapper mapper) : base(ctx)
        {
            _ctx = ctx;
            _mapper = mapper;
        }


        public Task<PagedList<LockerReadDto>> GetLockersAsync(Guid locationId, LockerParameters parameters)
        {
            var lockers = GetAll().Where(model => model.LocationId == locationId).OrderBy(model => model.Name);
            var lockerReadDto = _mapper.Map<ICollection<LockerReadDto>>(lockers);

            return Task.FromResult(PagedList<LockerReadDto>.ToPagedList(lockerReadDto,
                parameters.PageNumber,
                parameters.PageSize));
        }
        public IEnumerable<LockerReadDto> GetLockersPerLocation(Guid locationId)
        {
            var lockers = GetAll().Where(model => model.LocationId == locationId).OrderBy(model => model.Name);
            var lockerReadDto = _mapper.Map<IEnumerable<LockerReadDto>>(lockers);

            return lockerReadDto;
        }

    }
}
