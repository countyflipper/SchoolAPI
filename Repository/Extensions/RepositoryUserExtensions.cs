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

        //public static IQueryable<Employee> Search(this IQueryable<Employee> employees, string searchTerm)
        //{
        //    if (string.IsNullOrWhiteSpace(searchTerm))
        //        return employees;

        //    var lowerCaseTerm = searchTerm.Trim().ToLower();

        //    return employees.Where(e => e.Name.ToLower().Contains(lowerCaseTerm));
        //}

        //public static IQueryable<Employee> Sort(this IQueryable<Employee> employees, string orderByQueryString)
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
