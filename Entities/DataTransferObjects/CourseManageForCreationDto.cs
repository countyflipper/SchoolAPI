using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Entities.DataTransferObjects
{
    public class CourseManageForCreationDto
    {

        public int AssigmentID { get; set; }

        public string AssignmentTitle { get; set; }

        public string Description { get; set; }
    }
}
