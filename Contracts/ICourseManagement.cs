using Entities.Models;
using System;
using System.Collections.Generic;
namespace Contracts
{
    public interface ICourseManagement
    {
        IEnumerable<CourseManagement> GetAllCourseManagment(bool trackChanges);
        CourseManagement GetCourseManagement(Guid companyId, bool trackChanges);
    }
}

