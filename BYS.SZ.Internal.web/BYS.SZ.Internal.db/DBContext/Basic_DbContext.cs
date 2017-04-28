using BYS.SZ.Internal.db.Entities;
using BYS.SZ.Internal.db.Entities.Dimension;
using BYS.SZ.Internal.db.Entities.Fact;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.DBContext
{
    public class Basic_DbContext : DbContext
    {
        public Basic_DbContext() : base("BYDataConn")
        {
            Database.SetInitializer<Basic_DbContext>(new Basic_DbContextInitializer());
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Employee_Cost> Employee_Cost { get; set; }
        public DbSet<BillingInfo> BillingInfo { get; set; }
        public DbSet<MSTitle> MSTitle { get; set; }
        public DbSet<SOW> SOW { get; set; }
        public class Basic_DbContextInitializer : CreateDatabaseIfNotExists<Basic_DbContext>
        {
            protected override void Seed(Basic_DbContext context)
            {
                context.Employee.AddRange(new List<Employee>
                {
                    new Employee { UserName ="Pengmeng Wu", UserAlias = "v-pengwu", BeyondSoftID = 00029522,  Email = "wupengmeng@beyondsoft.com"},
                    new Employee { UserName ="Yuling Jiao", UserAlias = "v-yuljia", BeyondSoftID = 00032836,  Email = "jiaoyuling@beyondsoft.com"}
                });
                base.Seed(context);
            }
        }
    }
}
