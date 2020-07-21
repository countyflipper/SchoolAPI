using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }



        public async Task<PagedList<User>> GetAllUserAsync( UserParameter userParameters, bool trackChanges)
        {
            var employees = await  FindAll(trackChanges)
                .FilterEmployees(userParameters.MinAge, userParameters.MaxAge)
                .Search(userParameters.UserName)
                 .OrderBy(e => e.Id)
                .ToListAsync();

            return PagedList<User>
                .ToPagedList(employees, userParameters.PageNumber, userParameters.PageSize);
        }

        public async Task<User> GetUser(Guid id, bool trackChanges) =>
            await FindByCondition(e => e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public IEnumerable<User> IGetAllUsers( bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.UserName)
           .ToList();


        //public User GetUser(Guid Id, bool trackChanges) =>
        // FindByCondition(c => c.Id.Equals(Id), trackChanges)
        //.SingleOrDefault();


        public void CreateUser(User user) => Create(user);

        public IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToList();

        public void DeleteUser(User user)
        {
            Delete(user);
        }
    }
}
