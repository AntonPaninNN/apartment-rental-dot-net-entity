using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Configuration
{
    class RentalStatusConfiguration : EntityBaseConfiguration<RentalStatus>
    {
        public RentalStatusConfiguration()
        {
            Property(rs => rs.Status).IsRequired();
        }
    }
}
