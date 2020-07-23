using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    UserName = "sderosa",
                    Password = "pass123",
                    Email = "sderosa@njit.edu",
                    Status = "Active",
                    SystemRoleID =2000001,
                    age = 34,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    CourseID = new Guid("6B172B1B-F32D-4DFD-BE2F-0A6C56BC2446")
                },
                new User
                {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    UserName = "zwaltz",
                    Password = "hippo87",
                    Email = "zwaltz@njit.edu",
                    Status = "Active",
                    SystemRoleID = 3000008,
                    age = 24,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    CourseID= new Guid("7D31F5E1-BFB4-4E35-983D-D33269299E03")
                },
                 new User
                 {
                     Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                     UserName = "stussel",
                     Password = "newyork1",
                     Email = "stussel@njit.edu",
                     Status = "Active",
                     SystemRoleID = 8000007,
                     age = 48,
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now,
                     OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                     CourseID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
                 }
            );;
        }
    }
}