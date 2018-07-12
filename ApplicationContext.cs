using EntityContext.Configuration;
using EntityContext.Initializers;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalStatus> RentalStatuses { get; set; }

        static ApplicationContext()
        {
           // Database.SetInitializer<ApplicationContext>(new CustomersInitializer());
        }

        public ApplicationContext() : base("UserContext7")
        {
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ApartmentConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new RentalConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new RentalStatusConfiguration());
        }
    }
}
