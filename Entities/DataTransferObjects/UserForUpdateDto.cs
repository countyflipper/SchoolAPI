using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserForUpdateDto
    {
        [Required(ErrorMessage = "Username is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Username is 20 characters.")]
        [MinLength(10, ErrorMessage = "Minimum length for the Username is 10 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Email is 20 characters.")]
        [MinLength(5, ErrorMessage = "Minimum length for the Email is 5 characters.")]
        public string email { get; set; }


        [Required(ErrorMessage = "Email is a required field.")]
        public string status { get; set; }

        public int age { get; set; }

        public string OrganizationId { get; set; }

        public string CourseID { get; set; }
    }
}
