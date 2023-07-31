using EmployeeAccounting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAccounting.Forms
{
    public partial class EmployeeStatForm : Form
    {
        private readonly EmployeeDirectory _employeeDirectory;

        public EmployeeStatForm(EmployeeDirectory employeeDirectory)
        {
            InitializeComponent();
            _employeeDirectory = employeeDirectory;
        }

        private void ShowStatBtn_Click(object sender, EventArgs e)
        {
            int hired = 0;
            int fired = 0;
            DateTime startDate = StartTimePicker.Value.ToUniversalTime();
            DateTime endDate = EndTimePicker.Value.ToUniversalTime();
            string division = DivisionBox.Text.Trim();
            var employees = _employeeDirectory.GetRecords();
            foreach (var employee in employees)
            {
                if (division.Length != 0 && employee.Division.Name != division)
                    continue;
                if (startDate < employee.HireDate && employee.HireDate < endDate)
                    hired++;
                if (startDate < employee.FireDate && employee.FireDate < endDate)
                    fired++;
            }
            HireLabel.Text = hired.ToString();
            FireLabel.Text = fired.ToString();
        }
    }
}
