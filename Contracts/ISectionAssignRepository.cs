using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface ISectionAssignRepository
    {

        IEnumerable<SectionAssign> GetAllSectionAssigns(bool trackChanges);
        SectionAssign GetSectionAssign(Guid companyId, bool trackChanges);
    }
}