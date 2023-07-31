using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Models
{
    [Table("employee")]
    public class Employee
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("personnel_number")]
        public string PersonnelNumber { get; set; }
        [Column("position")]
        public string Position { get; set; }

        [InverseProperty("Employees")]
        [Column("division_id")]
        public Division Division { get; set; }

        [Column("email")]
        public string Email { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("hire_date")]
        public DateTime HireDate { get; set; }
        [Column("termination_date")]
        public DateTime? FireDate { get; set;}
        [Column("status")]
        public RecordStatus Status { get; set; }

        // for ef init
        private Employee()
        {
        }

        public Employee(string name, string personnelNumber, string position, Division division,
            string email, string phoneNumber)
        {
            Name = name;
            PersonnelNumber = personnelNumber;
            Position = position;
            Division = division;
            Email = email;
            PhoneNumber = phoneNumber;
            HireDate = DateTime.UtcNow;
            Status = RecordStatus.ACTIVE;
        }

        public Employee(string name, string personnelNumber, string position, Division division,
            string email, string phoneNumber, DateTime hireDate, DateTime terminationDate)
        {
            Name = name;
            PersonnelNumber = personnelNumber;
            Position = position;
            Division = division;
            Email = email;
            PhoneNumber = phoneNumber;
            HireDate = hireDate;
            FireDate = terminationDate;
            Status = RecordStatus.ACTIVE;
        }
    }
}
