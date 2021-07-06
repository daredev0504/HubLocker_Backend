using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Data.Data;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Data.DataAccess.Implementation
{
    public class LocationRepo : GenericRepository<Location>, ILocationRepo
    {
        public LocationRepo(ApplicationDbContext ctx) : base(ctx)
        {
        }



    }
}
