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
                    Id = new Guid("8d8f7441-0c40-4369-badf-ed3eca05b248"),
                    City = "Lekki",
                    State = "Lagos"
                },
                new Location
                { 
                    Id = new Guid("2c02c737-7e84-4e8c-ad23-b7afaac610be"),
                    City = "Ikeja",
                    State = "Lagos"
                });
        }
    }
}
