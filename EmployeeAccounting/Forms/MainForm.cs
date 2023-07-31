using EmployeeAccounting.Database;
using EmployeeAccounting.Forms;
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

namespace EmployeeAccounting
{
    public partial class MainForm : Form
    {
        private readonly EmployeeDirectory _employeeDirectory;
        private readonly DivisionDirectory _divisionDirectory;

        public MainForm(EmployeeDirectory employeeDirectory, DivisionDirectory divisionDirectory)
        {
            InitializeComponent();
            _employeeDirectory = employeeDirectory;
            _divisionDirectory = divisionDirectory;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var employees = ImportXlsx.ImportEmployeesFromXlsx("_-_-_-_-_-_-_.xlsx");
            ImportData(employees, _employeeDirectory);
            var divisions = ImportXlsx.ImporDivisionsFromXlsx("_-_-_-_-_-_-_.xlsx");
            ImportData(divisions, _divisionDirectory);

            
        }

        private void ShowAllEmployeesBtn_Click(object sender, EventArgs e)
        {
            SetTable(_employeeDirectory.GetRecords());
        }

        private void AddEmloyeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeAddForm addForm = new(_employeeDirectory);
            addForm.ShowDialog();
            SetTable(_employeeDirectory.GetRecords());
        }

        private void FireEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeFireForm fireForm = new(_employeeDirectory);
            fireForm.ShowDialog();
            SetTable(_employeeDirectory.GetRecords());
        }

        private void FindEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeFindForm findForm = new(_employeeDirectory);
            findForm.ShowDialog();
            if (findForm.returnValue != null)
                SetTable(findForm.returnValue);
        }

        private void FilterEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeFilterForm filterForm = new(_employeeDirectory);
            filterForm.ShowDialog();
            if (filterForm.returnValue != null)
                SetTable(filterForm.returnValue);
        }

        private void ShowStatBtn_Click(object sender, EventArgs e)
        {
            EmployeeStatForm statForm = new(_employeeDirectory);
            statForm.ShowDialog();
        }

        private void SetTable(IEnumerable<Employee> records)
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = records.ToDataTable();
            dataGridView.DataSource = SBind;
        }

        private void ImportData<T>(IEnumerable<T> items, BaseDirectory<T> directory)
        {
            foreach (var item in items)
            {
                directory.SaveRecord(item);
            }
        }
    }
}
