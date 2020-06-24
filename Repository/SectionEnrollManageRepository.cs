using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SectionEnrollManageRepository : RepositoryBase<SectionEnrollManage>, ISectionEnrollManage
    {
        public SectionEnrollManageRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}