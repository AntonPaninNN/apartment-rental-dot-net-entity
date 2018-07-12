using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Configuration
{
    class RentalConfiguration : EntityBaseConfiguration<Rental>
    {
        public RentalConfiguration()
        {
            Property(r => r.RentalDate).IsRequired();
            Property(r => r.ReturnedDate).IsRequired();
        }
    }
}
