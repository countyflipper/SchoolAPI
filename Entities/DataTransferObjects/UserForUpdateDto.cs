using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserForUpdateDto
    {
        [Required(ErrorMessage = "Organization name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        [MinLength(5, ErrorMessage = "Minimum length for the Name is 60 characters.")]
        public string email { get; set; }

        [Required(ErrorMessage = "User email is a required field.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Username is a required field.")]
        public string Status { get; set; }
    }
}
