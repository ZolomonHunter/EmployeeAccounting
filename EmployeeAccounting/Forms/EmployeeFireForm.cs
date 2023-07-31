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
    public partial class EmployeeFireForm : Form
    {
        private readonly EmployeeDirectory _employeeDirectory;

        public EmployeeFireForm(EmployeeDirectory employeeDirectory)
        {
            InitializeComponent();
            _employeeDirectory = employeeDirectory;
        }

        private void FireBtn_Click(object sender, EventArgs e)
        {
            string personnelNumber = NameBox.Text.Trim();
            if (personnelNumber.Length == 0)
            {
                MessageBox.Show("Поле номера не может быть пустым", "Ошибка удаления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee? employee = _employeeDirectory.GetRecord(personnelNumber);
            if (employee == null)
            {
                MessageBox.Show("Работника с таким номером не существует", "Ошибка удаления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _employeeDirectory.DeleteRecord(employee);
            Close();
        }

        private void EmployeeFireForm_Load(object sender, EventArgs e)
        {

        }
    }
}
