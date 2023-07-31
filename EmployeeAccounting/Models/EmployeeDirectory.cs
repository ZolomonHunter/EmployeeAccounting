using EmployeeAccounting.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Models
{
    public class EmployeeDirectory : BaseDirectory<Employee>
    {
        public EmployeeDirectory(DirectoriesContext context) : base(context)
        {
        }

        public override void DeleteRecord(Employee record)
        {
            record.Status = RecordStatus.CLOSED;
            _context.Employees.Update(record);
            _context.SaveChanges();
        }

        public override Employee? GetRecord(int id)
        {
            return _context.Employees.Find(id);
        }

        public Employee? GetRecord(string personnelNumber)
        {
            return _context.Employees.FirstOrDefault(e => e.PersonnelNumber == personnelNumber);
        }

        public override IEnumerable<Employee> GetRecords()
        {
            return _context.Employees.Include("Division");
        }

        public override Employee? SaveRecord(Employee record)
        {
            // throw exception
            if (_context.Employees.Any(e => e.PersonnelNumber == record.PersonnelNumber || 
                e.Email == record.Email || e.PhoneNumber == record.PhoneNumber))
                return null;

            var dbDivision = _context.Divisions.FirstOrDefault(e => e.Name == record.Division.Name);
            if (dbDivision != null)
                record.Division = dbDivision;

            var result = _context.Employees.Add(record);
            _context.SaveChanges();

            if (record.Position == "Руководитель подразделения")
            {
                record.Division.Manager = record;
                _context.SaveChanges();
            }
             
            return result.Entity;
        }
    }
}
