using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserForCreationDto
    {
        public string Username { get; set; }

        public string email { get; set; }

        public string status { get; set; }

        public string OrganizationId { get; set; }

        public string CourseID { get; set; }
    }
}
