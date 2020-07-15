using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Entities.DataTransferObjects
{
    public class CourseManageForCreationDto
    {
        [Required(ErrorMessage = "Assignment ID is a required field.")]
        public int AssigmentID { get; set; }

        [Required(ErrorMessage = "Assignment title is a required field.")]
        public string AssignmentTitle { get; set; }

        [Required(ErrorMessage = "Assignment description is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        [MinLength(20, ErrorMessage = "Minimum length for the Name is 20 characters.")]
        public string Description { get; set; }
    }
}
