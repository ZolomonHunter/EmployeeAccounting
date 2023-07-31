using EmployeeAccounting.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Models
{
    public abstract class BaseDirectory<T>
    {
        protected readonly DirectoriesContext _context;

        protected BaseDirectory(DirectoriesContext context)
        {
            _context = context;
        }

        public abstract T? SaveRecord(T record);
        public abstract void DeleteRecord(T record);
        public abstract T? GetRecord(int id);
        public abstract IEnumerable<T> GetRecords();


    }
}
