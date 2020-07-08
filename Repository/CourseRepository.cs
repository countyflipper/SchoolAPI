﻿using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CourseRepository : RepositoryBase<Courses>, ICourseRepository
    {
        public CourseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }



        public IEnumerable<Courses> GetAllCourses(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.CourseName)
           .ToList();


        public Courses GetCourse(Guid Id, bool trackChanges) =>
         FindByCondition(c => c.Id.Equals(Id), trackChanges)
        .SingleOrDefault();
    }
}