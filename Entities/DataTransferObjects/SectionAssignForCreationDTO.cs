using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class SectionAssignForCreationDTO
    {
        [Required(ErrorMessage = "SubmissionText  is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        [MinLength(10, ErrorMessage = "Minimum length for the Name is 10 characters.")]
        public string SubmissionText { get; set; }
      
        
        [Required(ErrorMessage = "Score  is a required field.")]
        public int Score { get; set; }

        [Required(ErrorMessage = "CreatedDate  is a required field.")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "UpdatedDate  is a required field.")]
        public DateTime UpdatedDate { get; set; }

        public string UsersID { get; set; }

        public string AssignID { get; set; }
    }
}
