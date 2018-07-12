using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class ApartmentRepository : BaseRepository, IRepository<Apartment>
    {
        public ApartmentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Apartments.Count();
        }

        public void Create(Apartment item)
        {
            _context.Apartments.Add(item);
        }

        public void Delete(int id)
        {
            Apartment item = _context.Apartments.Find(id);
            if (item != null)
                _context.Apartments.Remove(item);
        }

        public Apartment Get(int id)
        {
            return _context.Apartments.Find(id);
        }

        public IEnumerable<Apartment> GetAll()
        {
            return _context.Apartments;
        }

        public void Update(Apartment item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
