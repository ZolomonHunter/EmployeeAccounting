using EmployeeAccounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Database
{
    public class DirectoriesContext : DbContext
    {
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Employee> Employees { get; set; }


        public DirectoriesContext(DbContextOptions<DirectoriesContext> options) : base(options) 
        {
        }
    }
}
