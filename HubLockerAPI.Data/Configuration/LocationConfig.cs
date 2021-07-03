using System;
using HubLockerAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubLockerAPI.Data.Configuration
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    City = "Lekki",
                    State = "Lagos"
                },
                new Location
                { 
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    City = "Ikeja",
                    State = "Lagos"
                });
        }
    }
}
