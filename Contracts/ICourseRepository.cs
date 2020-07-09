using Entities.Models;
using System;
using System.Collections.Generic;


namespace Contracts
{
    public interface ICourseRepository
    {
        IEnumerable<Courses> GetAllCourses(bool trackChanges);
        Courses GetCourse(Guid companyId, bool trackChanges);

        void CreateCourse(Courses courses);

        IEnumerable<Courses> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteCourse(Courses organization);
    }
}

