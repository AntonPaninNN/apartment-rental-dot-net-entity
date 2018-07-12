using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Configuration
{
    class ApartmentConfiguration : EntityBaseConfiguration<Apartment>
    {
        public ApartmentConfiguration()
        {
            Property(a => a.Address).IsRequired();
            Property(a => a.Cost).IsRequired();
            Property(a => a.Description).IsOptional().HasMaxLength(4000);
            Property(a => a.Floor).IsOptional();
            Property(a => a.RoomNumber).IsRequired();
        }
    }
}
