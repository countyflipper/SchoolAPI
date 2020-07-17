using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SectionEnrollManage
    {
        [Column("SectionEnrollID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "SectionEnrollManage name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public ICollection<User> Users { get; set; }
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