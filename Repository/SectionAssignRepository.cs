using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SectionAssignRepository : RepositoryBase<SectionAssign>, ISectionAssignRepository
    {
        public SectionAssignRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}