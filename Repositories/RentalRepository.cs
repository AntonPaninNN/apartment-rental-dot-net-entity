using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class RentalRepository : BaseRepository, IRepository<Rental>
    {
        public RentalRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Rentals.Count();
        }

        public void Create(Rental item)
        {
            _context.Rentals.Add(item);
        }

        public void Delete(int id)
        {
            Rental item = _context.Rentals.Find(id);
            if (item != null)
                _context.Rentals.Remove(item);
        }

        public Rental Get(int id)
        {
            return _context.Rentals.Find(id);
        }

        public IEnumerable<Rental> GetAll()
        {
            return _context.Rentals;
        }

        public void Update(Rental item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
