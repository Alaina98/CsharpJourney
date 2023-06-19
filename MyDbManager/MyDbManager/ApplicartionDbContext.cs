using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbManager
{
    internal class ApplicartionDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           // base.OnConfiguring(options);
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        DbSet<Employee> employees { get; set; }

    }
}
