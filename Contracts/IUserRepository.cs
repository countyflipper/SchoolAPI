using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUserAsync( UserParameter userParameters, bool trackChanges);
        //Task<IEnumerable<User>> GetAllUsers(UserParameter UserParameters, bool trackChanges);
        Task<User> GetUser(Guid companyId, bool trackChanges);
        IEnumerable<User> IGetAllUsers(bool trackChanges);

        void CreateUser(User user);

        IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteUser(User organization);
    }
}
