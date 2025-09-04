using DevExWithEntity.Entity;
using System;
using System.Data.Entity;
using System.Linq;

namespace DevExWithEntity.DataAccess.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=AppContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
