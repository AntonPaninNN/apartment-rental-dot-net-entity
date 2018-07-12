using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class ErrorRepository : BaseRepository, IRepository<Error>
    {
        public ErrorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Errors.Count();
        }

        public void Create(Error item)
        {
            _context.Errors.Add(item);
        }

        public void Delete(int id)
        {
            Error item = _context.Errors.Find(id);
            if (item != null)
                _context.Errors.Remove(item);
        }

        public Error Get(int id)
        {
            return _context.Errors.Find(id);
        }

        public IEnumerable<Error> GetAll()
        {
            return _context.Errors;
        }

        public void Update(Error item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
