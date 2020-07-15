using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class SectionAssignDTO
    {
        public string SubmissionText { get; set; }

        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string UsersID { get; set; }

        public string AssignID { get; set; }
    }
}
