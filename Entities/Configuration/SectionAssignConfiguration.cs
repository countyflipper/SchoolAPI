using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class SectionAssignConfiguration : IEntityTypeConfiguration<SectionAssign>
    {
        public void Configure(EntityTypeBuilder<SectionAssign> builder)
        {
            builder.HasData
            (
                new SectionAssign
                {
                    Id = new Guid("4FB597EA-72AA-4DDF-8D06-F009AD8A2D3A"),
                    SubmissionText = "Please see link to assignment.",
                    Score = 91,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    AssignID= "C769E19D-C895-4AD0-97DC-9B497BFF0D3E",
                    UsersID= "80abbca8-664d-4b20-b5de-024705497d4a",
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new SectionAssign
                {
                    Id = new Guid("A884663B-F3C7-46DA-A541-9CEF2FF12D66"),
                    SubmissionText = "Please see link to assignment.",
                    Score = 84,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    AssignID = "C769E19D-C895-4AD0-97DC-9B497BFF0D3E",
                    UsersID = "021ca3c1-0deb-4afd-ae94-2159a8479811",
                    //UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                 new SectionAssign
                 {
                     Id = new Guid("DF38BDF1-C93B-43E6-9ED1-0DA79D774967"),
                     SubmissionText = "Please see link to assignment.",
                     Score = 99,
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now,
                     AssignID = "C769E19D-C895-4AD0-97DC-9B497BFF0D3E",
                     UsersID = "86dba8c0-d178-41e7-938c-ed49778fb52a",
                     //UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                     //OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );
        }
    }
}
