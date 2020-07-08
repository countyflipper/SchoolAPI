using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Repository
{
    public class SectionAssignRepository : RepositoryBase<SectionAssign>, ISectionAssignRepository
    {
        public SectionAssignRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<SectionAssign> GetAllSectionAssigns(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.AssignID)
           .ToList();


        public SectionAssign GetSectionAssign(Guid Id, bool trackChanges) =>
         FindByCondition(c => c.Id.Equals(Id), trackChanges)
        .SingleOrDefault();
    }
}