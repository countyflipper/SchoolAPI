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

        public int AssigmentID { get; set; }

        public string AssignmentTitle { get; set; }

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