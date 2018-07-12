using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class RentalStatusRepository : BaseRepository, IRepository<RentalStatus>
    {
        public RentalStatusRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.RentalStatuses.Count();
        }

        public void Create(RentalStatus item)
        {
            _context.RentalStatuses.Add(item);
        }

        public void Delete(int id)
        {
            RentalStatus item = _context.RentalStatuses.Find(id);
            if (item != null)
                _context.RentalStatuses.Remove(item);
        }

        public RentalStatus Get(int id)
        {
            return _context.RentalStatuses.Find(id);
        }

        public IEnumerable<RentalStatus> GetAll()
        {
            return _context.RentalStatuses;
        }

        public void Update(RentalStatus item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
