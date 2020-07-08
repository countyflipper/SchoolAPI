using Entities.Models;
using System;
using System.Collections.Generic;


namespace Contracts
{
    public interface ICourseRepository
    {
        IEnumerable<Courses> GetAllCourses(bool trackChanges);
        Courses GetCourse(Guid companyId, bool trackChanges);
    }
}

