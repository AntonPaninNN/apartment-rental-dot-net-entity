using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class UserRepository : BaseRepository, IRepository<User>
    {
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Users.Count();
        }

        public void Create(User item)
        {
            _context.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = _context.Users.Find(id);
            if (user != null)
                _context.Users.Remove(user);
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Update(User item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
