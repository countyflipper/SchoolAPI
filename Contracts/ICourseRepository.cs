using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICourseRepository
    {
        IEnumerable<Courses> GetAllCourses(bool trackChanges);
        Courses GetCourse(Guid companyId, bool trackChanges);

        Task<PagedList<Courses>> GetCoursesAsync(Guid courseID, CoursesParameters coursesParameters, bool trackChanges);
        Task<Courses> GetCourseAsync(Guid companyId, bool trackChanges);

        void CreateCourse(Courses courses);

        IEnumerable<Courses> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteCourse(Courses organization);
    }
}

