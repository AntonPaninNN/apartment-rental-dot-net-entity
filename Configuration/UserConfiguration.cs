using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Configuration
{
    class UserConfiguration : EntityBaseConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.CreationDate).IsRequired();
            Property(u => u.HashedPassword).IsRequired();
            Property(u => u.LockedFrom).IsOptional();
            Property(u => u.LockedMessage).IsOptional();
            Property(u => u.LockedTo).IsOptional();
            Property(u => u.Login).IsRequired().HasMaxLength(200);
            Property(u => u.Salt).IsRequired();
        }
    }
}
