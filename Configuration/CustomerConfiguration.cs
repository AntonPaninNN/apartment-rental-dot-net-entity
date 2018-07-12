using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Configuration
{
    class CustomerConfiguration : EntityBaseConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(c => c.DateOfBirth).IsRequired();
            Property(c => c.Email).IsRequired().HasMaxLength(200);
            Property(c => c.FirstName).IsRequired().HasMaxLength(200);
            Property(c => c.LastName).IsRequired().HasMaxLength(200);
            Property(c => c.Mobile).IsOptional().HasMaxLength(200);
            Property(c => c.Notes).IsOptional().HasMaxLength(4000);
            Property(c => c.PassportData).IsRequired();
            Property(c => c.RegistrationDate).IsRequired();
        }
    }
}
