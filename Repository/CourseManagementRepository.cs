using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Repository
{
    public class CourseManagementRepository : RepositoryBase<CourseManagement>, ICourseManagement
    {
        public CourseManagementRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<CourseManagement> GetAllCourseManagment(bool trackChanges) =>
   FindAll(trackChanges)
   .OrderBy(c => c.AssignmentTitle)
   .ToList();


        public CourseManagement GetCourseManagement(Guid Id, bool trackChanges) =>
         FindByCondition(c => c.Id.Equals(Id), trackChanges)
        .SingleOrDefault();
    }
}