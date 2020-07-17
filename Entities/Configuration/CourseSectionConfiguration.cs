using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseSectionConfiguration : IEntityTypeConfiguration<CourseSection>
    {
        public void Configure(EntityTypeBuilder<CourseSection> builder)
        {
            builder.HasData
            (
                new CourseSection
                {
                    Id = new Guid("6B172B1B-F32D-4DFD-BE2F-0A6C56BC2447"),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new CourseSection
                {
                    Id = new Guid("7D31F5E1-BFB4-4E35-983D-D33269299E04"),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                 new CourseSection
                 {
                     Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                     StartDate = DateTime.Now,
                     EndDate = DateTime.Now,
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now,
                     //UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                     //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );
        }
    }
}
