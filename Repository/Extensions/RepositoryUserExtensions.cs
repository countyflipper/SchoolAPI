using Entities.Models;
//using Repository.Extensions.Utility;
using System.Linq;
//using System.Linq.Dynamic.Core;

namespace Repository.Extensions
{
    public static class RepositoryUserExtensions
    {
        public static IQueryable<User> FilterEmployees(this IQueryable<User> users, uint minAge, uint maxAge) =>
            users.Where(e => (e.age >= minAge && e.age <= maxAge));

        public static IQueryable<User> Search(this IQueryable<User> user, string searchUsername)
        {
            if (string.IsNullOrWhiteSpace(searchUsername))
                return user;

            var lowerCaseTerm = searchUsername.Trim().ToLower();

            return user.Where(e => e.UserName.ToLower().Contains(lowerCaseTerm));
        }

        //public static IQueryable<User> Sort(this IQueryable<User> employees, string orderByQueryString)
        //{
        //    if (string.IsNullOrWhiteSpace(orderByQueryString))
        //        return employees.OrderBy(e => e.Name);

        //    var orderQuery = OrderQueryBuilder.CreateOrderQuery<Employee>(orderByQueryString);

        //    if (string.IsNullOrWhiteSpace(orderQuery))
        //        return employees.OrderBy(e => e.Name);

        //    return employees.OrderBy(orderQuery);
        //}
    }
}
