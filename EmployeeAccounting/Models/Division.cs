using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Models
{
    [Table("division")]
    public class Division
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        [Column("head_division_id")]
        public Division? HeadDivision { get; set; }

        [Column("manager_id")]
        public Employee? Manager { get; set; }

        [Column("status")]
        public RecordStatus Status { get; set; }

        [InverseProperty("Division")]
        public List<Employee> Employees { get; set; }

        // for ef init
        private Division() 
        { 
        }

        public Division(string name)
        {
            Name = name;
            Status = RecordStatus.ACTIVE;
            Employees = new List<Employee>();
        }
        public Division(string name, Division? headDivision) : this(name)
        {
            HeadDivision = headDivision;
        }
    }
}
