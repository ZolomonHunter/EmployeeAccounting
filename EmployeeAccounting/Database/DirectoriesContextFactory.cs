using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Database
{
    internal class DirectoriesContextFactory : IDesignTimeDbContextFactory<DirectoriesContext>
    {
        public DirectoriesContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DirectoriesContext>();
            optionsBuilder.UseNpgsql("Host=localhost; Database=postgres; Username=postgres; Password=admin");

            return new DirectoriesContext(optionsBuilder.Options);
        }
    }
}
