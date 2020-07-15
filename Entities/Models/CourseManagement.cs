using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class CourseManagement
    {
        [Column("CourseManagementID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Assignment ID is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Name is 20 characters.")]
        [MinLength(20, ErrorMessage = "Minimum length for the Name is 20 characters.")]
        public int AssigmentID { get; set; }

        [Required(ErrorMessage = "Assignment Title is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Name is 20 characters.")]
        [MinLength(20, ErrorMessage = "Minimum length for the Name is 20 characters.")]
        public string AssignmentTitle { get; set; }


        [Required(ErrorMessage = "Assignment description is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        [MinLength(20, ErrorMessage = "Minimum length for the Name is 20 characters.")]
        public string Description { get; set; }

        //public Courses Courses { get; set; }
        //----------------------------------------------------

        /*     [ForeignKey(nameof(User))]
             public Guid UserId { get; set; }
             public User User { get; set; }

             //----------------------------------------------------

             [ForeignKey(nameof(Organization))]
             public Guid OrganizationId { get; set; }

             public Organization Organization { get; set; }
        */
        //----------------------------------------------------
    }
}