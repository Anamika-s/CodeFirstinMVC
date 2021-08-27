using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachDemo.Models
{
    public class EmployeeDbContext: DbContext // FOr this we need Microsoft.EntityFrameworkCore;
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
                   : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
