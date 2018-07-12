using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Initializers
{
    class CustomersInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            for (int i = 0; i < 120; i++)
            {
                Customer customer = new Customer() { DateOfBirth = DateTime.Now,
                    Email = "customer_" + i + "@test.com",
                    FirstName = "FirstName_" + i,
                    LastName = "LastName_" + i,
                    Mobile = "Mobile_" + i,
                    Notes = "Notes_" + i,
                    PassportData = "PassData_" + i,
                    RegistrationDate = DateTime.Now };

                context.Customers.Add(customer);
                context.SaveChanges();
            }

            //base.Seed(context);
        }
    }
}
