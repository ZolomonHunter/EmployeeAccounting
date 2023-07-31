using EmployeeAccounting.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Database
{
    public static class ImportXlsx
    {
        static ImportXlsx()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public static IEnumerable<Employee> ImportEmployeesFromXlsx(string xlsxPath)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(xlsxPath)))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First(e => e.Name == "Сотрудники");
                var totalRows = myWorksheet.Dimension.End.Row;


                List<Employee> result = new();
                for (int rowNum = 2; rowNum <= totalRows; rowNum++)
                {
                    var name = myWorksheet.Cells[rowNum, 2].Value?.ToString();
                    var personnelNumber = myWorksheet.Cells[rowNum, 3].Value?.ToString();
                    var position = myWorksheet.Cells[rowNum, 4].Value?.ToString();
                    var division = myWorksheet.Cells[rowNum, 5].Value?.ToString();
                    var email = myWorksheet.Cells[rowNum, 6].Value?.ToString();
                    var phone = myWorksheet.Cells[rowNum, 7].Value?.ToString();
                    var hireDate = myWorksheet.Cells[rowNum, 8].Value?.ToString();
                    var terminationDate = myWorksheet.Cells[rowNum, 9].Value?.ToString();

                    // throw error or smth
                    if (name == null || personnelNumber == null || position == null ||
                        division == null || email == null || phone == null)
                        continue;

                    var currentEmployee = new Employee(
                        name,
                        personnelNumber,
                        position,
                        new Division(division),
                        email,
                        phone);
                    if (hireDate == null)
                        currentEmployee.HireDate = DateTime.UtcNow;
                    else
                        currentEmployee.HireDate = DateTime.Parse(hireDate).ToUniversalTime();
                    if (terminationDate != null)
                        currentEmployee.FireDate = DateTime.Parse(terminationDate).ToUniversalTime();
                    result.Add(currentEmployee);
                }
                return result;
            }
        }

        public static IEnumerable<Division> ImporDivisionsFromXlsx(string xlsxPath)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(xlsxPath)))
            {
                var myWorksheet = xlPackage.Workbook.Worksheets.First(e => e.Name == "Подразделения");
                var totalRows = myWorksheet.Dimension.End.Row;


                List<Division> result = new();
                for (int rowNum = 2; rowNum <= totalRows; rowNum++) //select starting row here
                {
                    var name = myWorksheet.Cells[rowNum, 2].Value?.ToString();
                    var headDivision = myWorksheet.Cells[rowNum, 3].Value?.ToString();

                    // throw error or smth
                    if (name == null)
                        continue;
                    var currentDivision = new Division(name);
                    if (headDivision != null)
                        currentDivision.HeadDivision = new Division(headDivision);
                    result.Add(currentDivision);
                }
                return result;
            }
        }
    }
}
