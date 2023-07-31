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
    public partial class EmployeeFilterForm : Form
    {
        private readonly EmployeeDirectory _employeeDirectory;
        public IEnumerable<Employee>? returnValue { get; private set; }

        public EmployeeFilterForm(EmployeeDirectory employeeDirectory)
        {
            InitializeComponent();
            _employeeDirectory = employeeDirectory;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string division = DivisionBox.Text.Trim();
            returnValue = _employeeDirectory.GetRecords()
                .Where(e => e.Division.Name == division);
            Close();
        }
    }
}
