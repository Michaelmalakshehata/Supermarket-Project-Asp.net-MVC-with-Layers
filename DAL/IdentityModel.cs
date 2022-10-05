using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationUserIdentity : IdentityUser
    {

    }
    public class ApplicationUserStore : UserStore<ApplicationUserIdentity>
    {
        public ApplicationUserStore() : base(new ApplicationDBContext())
        {

        }
        public ApplicationUserStore(DbContext db) : base(db)
        {

        }
    }

    public class ApplicationRoleManager : RoleManager<IdentityRole>
    {
        public ApplicationRoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDBContext()))
        {

        }
        public ApplicationRoleManager(DbContext db)
            : base(new RoleStore<IdentityRole>(db))
        {

        }
    }
    public class ApplicationUserManager : UserManager<ApplicationUserIdentity>
    {
        public ApplicationUserManager() : base(new ApplicationUserStore())
        {

        }
        public ApplicationUserManager(DbContext db) : base(new ApplicationUserStore(db))
        {

        }
    }
    public class Order
    {
        public int Id { get; set; }
        public string date { get; set; }
        public string Description { get; set; }
        public int totalPrice { get; set; }
        public int discount { get; set; }
        public virtual ApplicationUserIdentity appUser { get; set; }
    }
    public class ApplicationDBContext : IdentityDbContext<ApplicationUserIdentity>
    {

        public ApplicationDBContext() : 
            base("name=SuperCs")
        {

        }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
