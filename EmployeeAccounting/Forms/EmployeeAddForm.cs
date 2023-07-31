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
                ShowErrorMessage("Введите ФИО сотрудника");

            string number = NumberTextBox.Text.Trim();
            if (number.Length == 0)
                ShowErrorMessage("Введите табельный номер сотрудника");
            if (number.Any(e => e < '0' || e > '9'))
                ShowErrorMessage("Табельный номер содержит недопустимые символы");

            string position = PositionTextBox.Text.Trim();
            if (position.Length == 0)
                ShowErrorMessage("Введите должность сотрудника");

            string division = DivisionTextBox.Text.Trim();
            if (division.Length == 0)
                ShowErrorMessage("Введите подразделение сотрудника");

            string email = EmailTextBox.Text.Trim();
            if (email.Length == 0)
                ShowErrorMessage("Введите email сотрудника");
            if (!new EmailAddressAttribute().IsValid(email))
                ShowErrorMessage("Неправильный формат почты");

            string phone = PhoneTextBox.Text.Trim();
            if (!(phone.Length == 12 && phone.StartsWith("+7") ||
                    phone.Length == 11 && phone.StartsWith("8")))
                ShowErrorMessage("Неправильный формат номера телефона");

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
            MessageBox.Show(errorMsg, "Ошибка добавления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}