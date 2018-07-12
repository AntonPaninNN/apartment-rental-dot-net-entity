using EntityContext.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext
{
    public interface IUnitOfWork
    {
        void Save();

        IRepository<User> Users { get; }
        IRepository<Customer> Customers { get; }
        IRepository<Apartment> Apartments { get; }
        IRepository<Rental> Rentals { get; }
        IRepository<RentalStatus> RentalStatuses { get; }
        IRepository<Error> Errors { get; }
        IRepository<UserRole> Roles { get; }
    }
}
