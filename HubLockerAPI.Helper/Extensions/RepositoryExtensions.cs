using System.Linq;
using HubLockerAPI.Helper.Extensions.Utility;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Helper.Extensions
{
    public static class RepositoryExtensions
    {
        public static IQueryable<Location> FilterLocation(this IQueryable<Location> locations, string city, string state) =>
            locations.Where(e => (e.City == city || e.State == state));

        // this is an extention method for the IQueryable interfecae , this is a search filter
        public static IQueryable<Location> Search(this IQueryable<Location> locations, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return locations;
            var lowerCaseTerm = searchTerm.Trim()
                .ToLower();
            return locations.Where(e => e.City.ToLower().Contains(lowerCaseTerm) || e.State.ToLower().Contains(lowerCaseTerm));
        }

        // this is an extention method for the IQueryable interfecae , this is a sort filter
        //public static IQueryable<Locker> Sort(this IQueryable<Locker> lockers, string orderByQueryString)
        //{
        //    if (string.IsNullOrWhiteSpace(orderByQueryString))
        //        return lockers.OrderBy(e => e.Size);

        //    var orderQuery = OrderQueryBuilder.CreateOrderQuery<Locker>(orderByQueryString);

        //    if (string.IsNullOrWhiteSpace(orderQuery))
        //        return lockers.OrderBy(e => e.Size);


        //    return lockers.OrderBy(orderQuery);

        //}
    }
}
