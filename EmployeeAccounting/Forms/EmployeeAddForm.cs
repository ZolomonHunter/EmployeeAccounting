using EmployeeAccounting.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAccounting
{
    public partial class EmployeeAddForm : Form
    {
        private readonly EmployeeDirectory _employeeDirectory;

        public EmployeeAddForm(EmployeeDirectory employeeDirectory)
        {
            InitializeComponent();
            _employeeDirectory = employeeDirectory;
        }


        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            if (name.Length == 0)
                ShowErrorMessage("������� ��� ����������");

            string number = NumberTextBox.Text.Trim();
            if (number.Length == 0)
                ShowErrorMessage("������� ��������� ����� ����������");
            if (number.Any(e => e < '0' || e > '9'))
                ShowErrorMessage("��������� ����� �������� ������������ �������");

            string position = PositionTextBox.Text.Trim();
            if (position.Length == 0)
                ShowErrorMessage("������� ��������� ����������");

            string division = DivisionTextBox.Text.Trim();
            if (division.Length == 0)
                ShowErrorMessage("������� ������������� ����������");

            string email = EmailTextBox.Text.Trim();
            if (email.Length == 0)
                ShowErrorMessage("������� email ����������");
            if (!new EmailAddressAttribute().IsValid(email))
                ShowErrorMessage("������������ ������ �����");

            string phone = PhoneTextBox.Text.Trim();
            if (!(phone.Length == 12 && phone.StartsWith("+7") ||
                    phone.Length == 11 && phone.StartsWith("8")))
                ShowErrorMessage("������������ ������ ������ ��������");

            Employee employee = new Employee(
                name,
                number,
                position,
                new Division(division),
                email,
                phone);

            _employeeDirectory.SaveRecord(employee);
            this.Close();
        }

        private void ShowErrorMessage(string errorMsg)
        {
            MessageBox.Show(errorMsg, "������ ����������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}