using EmployeeAccounting.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Models
{
    public class DivisionDirectory : BaseDirectory<Division>
    {
        public DivisionDirectory(DirectoriesContext context) : base(context)
        {
        }

        public override void DeleteRecord(Division record)
        {
            record.Status = RecordStatus.CLOSED;
            _context.Divisions.Update(record);
            _context.SaveChanges();
        }

        public override Division? GetRecord(int id)
        {
            return _context.Divisions.Find(id);
        }

        public override IEnumerable<Division> GetRecords()
        {
            return _context.Divisions;
        }

        public override Division? SaveRecord(Division record)
        {
            var dbDivision = _context.Divisions.FirstOrDefault(e => e.Name == record.Name);
            
            if (record.HeadDivision != null)
            {
                var dbHeadDivision = _context.Divisions.FirstOrDefault(e => e.Name == record.HeadDivision.Name);
                if (dbHeadDivision != null)
                    record.HeadDivision = dbHeadDivision;
            }

            Division? result;
            if (dbDivision != null)
            {
                dbDivision.Name = record.Name;
                dbDivision.HeadDivision = record.HeadDivision;
                result = dbDivision;
            }
            else
                result = _context.Divisions.Add(record)?.Entity;

            _context.SaveChanges();
            return result;
        }
    }
}
