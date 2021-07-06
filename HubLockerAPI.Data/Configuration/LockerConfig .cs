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
                    Id = new Guid("580b289e-c1c8-4e00-814c-34195da42740"),
                    Name = "Lekki locker 1",
                    LocationId = new Guid("8d8f7441-0c40-4369-badf-ed3eca05b248")
                    
                },
                new Locker
                { 
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Ikeja locker 1",
                    LocationId = new Guid("2c02c737-7e84-4e8c-ad23-b7afaac610be")
                   
                },
                new Locker
                {
                    Id = new Guid("b3fdcc9a-96bd-437b-b6fb-1de786c86d0d"),
                    Name = "Lekki locker 2",
                    LocationId = new Guid("8d8f7441-0c40-4369-badf-ed3eca05b248")
                    
                },
                new Locker
                {
                    Id = new Guid("144b9ab9-61b3-4450-a74b-cc3f4c9acbc9"),
                    Name = "Ikeja locker 3",
                    LocationId = new Guid("2c02c737-7e84-4e8c-ad23-b7afaac610be")
                    
                });
        }
    }
}
