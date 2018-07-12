using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class CustomerRepository : BaseRepository, IRepository<Customer>
    {
        public CustomerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Customers.Count();
        }

        public void Create(Customer item)
        {
            _context.Customers.Add(item);
        }

        public void Delete(int id)
        {
            Customer item = _context.Customers.Find(id);
            if (item != null)
                _context.Customers.Remove(item);
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public void Update(Customer item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
