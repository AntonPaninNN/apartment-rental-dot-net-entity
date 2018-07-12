using EntityContext.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private ApplicationContext _context;

        private IRepository<User> _userRepository;
        private IRepository<UserRole> _roleRepository;
        private IRepository<Apartment> _apartmentRepository;
        private IRepository<Customer> _customerRepository;
        private IRepository<Rental> _rentalRepository;
        private IRepository<RentalStatus> _rentalStatusRepository;
        private IRepository<Error> _errorRepository;

        private bool _disposed = false;

        public UnitOfWork()
        {
            _context = new ApplicationContext();
        }

        public IRepository<User> Users
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);
                return _userRepository;
            }
        }

        public IRepository<Apartment> Apartments
        {
            get
            {
                if (_apartmentRepository == null)
                    _apartmentRepository = new ApartmentRepository(_context);
                return _apartmentRepository;
            }
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_context);
                return _customerRepository;
            }
        }

        public IRepository<Rental> Rentals
        {
            get
            {
                if (_rentalRepository == null)
                    _rentalRepository = new RentalRepository(_context);
                return _rentalRepository;
            }
        }

        public IRepository<RentalStatus> RentalStatuses
        {
            get
            {
                if (_rentalStatusRepository == null)
                    _rentalStatusRepository = new RentalStatusRepository(_context);
                return _rentalStatusRepository;
            }
        }

       public IRepository<Error> Errors
        {
            get
            {
                if (_errorRepository == null)
                    _errorRepository = new ErrorRepository(_context);
                return _errorRepository;
            }
        }

        public IRepository<UserRole> Roles
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new UserRoleRepository(_context);
                return _roleRepository;
            }
        }

        public void Save()
        {
            _context.Commit();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this._disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
