using System;
using HubLockerAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubLockerAPI.Data.Configuration
{
    public class LockerConfig : IEntityTypeConfiguration<Locker>
    {
        public void Configure(EntityTypeBuilder<Locker> builder)
        {
            builder.HasData(
                new Locker
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "Lekki locker 1",
                    LocationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    
                },
                new Locker
                { 
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Ikeja locker 1",
                    LocationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                   
                },
                new Locker
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "Lekki locker 2",
                    LocationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    
                },
                new Locker
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Ikeja locker 3",
                    LocationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    
                });
        }
    }
}
