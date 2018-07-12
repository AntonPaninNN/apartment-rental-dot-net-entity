using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Configuration
{
    class UserRoleConfiguration : EntityBaseConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            Property(ur => ur.Role).IsRequired();
        }
    }
}
