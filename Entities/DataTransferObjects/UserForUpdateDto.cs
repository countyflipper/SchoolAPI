using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserForUpdateDto
    {

        public string email { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
    }
}
