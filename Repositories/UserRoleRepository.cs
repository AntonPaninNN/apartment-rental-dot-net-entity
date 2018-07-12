using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Repositories
{
    public class UserRoleRepository : BaseRepository, IRepository<UserRole>
    {
        public UserRoleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.UserRoles.Count();
        }

        public void Create(UserRole item)
        {
            _context.UserRoles.Add(item);
        }

        public void Delete(int id)
        {
            UserRole roles = _context.UserRoles.Find(id);
            if (roles != null)
                _context.UserRoles.Remove(roles);
        }

        public UserRole Get(int id)
        {
            return _context.UserRoles.Find(id);
        }

        public IEnumerable<UserRole> GetAll()
        {
            return _context.UserRoles;
        }

        public void Update(UserRole item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
