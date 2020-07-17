using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SectionAssign
    {
        [Column("SectionAssignID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Course name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]

        public string SubmissionText { get; set; }

        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string UsersID { get; set; }

        public string  AssignID { get; set; }

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