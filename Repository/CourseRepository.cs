using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Repository
{
    public class CourseRepository : RepositoryBase<Courses>, ICourseRepository
    {
        public CourseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }


        public async Task<PagedList<Courses>> GetCoursesAsync(CoursesParameters ecoursesParameters, bool trackChanges)
        {
            var employees = await FindAll(trackChanges)
              .OrderBy(e => e.CourseName)
              .ToListAsync();

            return PagedList<Courses>
              .ToPagedList(employees, ecoursesParameters.PageNumber, ecoursesParameters.PageSize);
        }


        public async Task<Courses> GetCourseAsync(Guid id, bool trackChanges) =>
            await FindByCondition(e => e.Id.Equals(id) && e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();


        public IEnumerable<Courses> GetAllCourses(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.CourseName)
           .ToList();


        public Courses GetCourse(Guid Id, bool trackChanges) =>
         FindByCondition(c => c.Id.Equals(Id), trackChanges)
        .SingleOrDefault();


        public void CreateCourse(Courses courses) => Create(courses);

        public IEnumerable<Courses> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToList();




        public void DeleteCourse(Courses courses)
        {
            Delete(courses);
        }
    }
}