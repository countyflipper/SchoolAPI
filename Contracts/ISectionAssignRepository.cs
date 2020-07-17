using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface ISectionAssignRepository
    {

        IEnumerable<SectionAssign> GetAllSectionAssigns(bool trackChanges);
        SectionAssign GetSectionAssign(Guid companyId, bool trackChanges);

        void CreateSectionAssign(SectionAssign sectionassign);

        IEnumerable<SectionAssign> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteSectionAssign(SectionAssign organization);
    }
}